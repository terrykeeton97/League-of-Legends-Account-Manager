using Acccount_Manager.Classes.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acccount_Manager.Classes.Data.LCUClientData
{
    internal class LCU
    {
        private HttpClient _httpClient;
        private string _lcuBaseUrl;
        private static string Token { get; set; }
        private static ushort Port { get; set; }

        internal LCU()
        {
            var handler = new HttpClientHandler
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                }
            };
            _httpClient = new HttpClient(handler);
        }

        public async Task Login(string username, string password)
        {
            if (Utils.IsClientRunning())
            {
                Utils.KillAllLeagueProcesses();
                await Task.Delay(4000); //Give the processes time to exit
            }
            Utils.StartClient();

            while (!Utils.IsRiotClientRunning() || Imports.FindWindow("RCLIENT", "Riot Client") == IntPtr.Zero)
                await Task.Delay(2000); //Wait for both checks to return true so we know the client is ready to login since Riot can't code a normal game client

            if (RiotClientConnect())
            {
                string loginBody = $"{{\"username\":\"{username}\",\"password\":\"{password}\",\"persistLogin\":false}}";
                string response = await MakeRiotRequestWithJson("put", "rso-auth/v1/session/credentials", loginBody);

                if (response.Contains("auth_failure"))
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private string GetRiotClientCommandLineArgs()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c wmic PROCESS WHERE name='RiotClientUx.exe' GET commandline";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            return output;
        }

        private string[] GetRiotClientPortAndAuthKey()
        {
            string[] retvalues = new string[3];
            string wholeCommandLine = GetRiotClientCommandLineArgs();
            string[] splitSpaces = wholeCommandLine.Split(' ');
            foreach (string commandLineArg in splitSpaces)
            {
                if (commandLineArg.Contains("="))
                {

                    string key = commandLineArg.Split('=')[0];
                    string value = commandLineArg.Split('=')[1];

                    if (key == "--app-port")
                    {
                        retvalues[0] = value;
                    }
                    else if (key == "--remoting-auth-token")
                    {
                        string Token = value;
                        retvalues[1] = Convert.ToBase64String(Encoding.ASCII.GetBytes($"riot:{Token}"));
                    }
                    else if (key == "--app-pid")
                    {
                        retvalues[2] = value;
                    }
                }
            }
            return retvalues;
        }

        private bool RiotClientConnect() //cannot make more than one request. removed static method, internal LCU only seems to set once on runtime so http client isn't null?
        {
            string[] items = GetRiotClientPortAndAuthKey();

            foreach (string nullCheck in items)
            {
                if (nullCheck == null || nullCheck == "")
                    return false;
            }

            Token = items[1];
            Port = ushort.Parse(items[0]);
            var ApiUri = "https://127.0.0.1:" + Port.ToString() + "/";

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Token);
            _httpClient.BaseAddress = new Uri(ApiUri);
            return true;
        }

        internal async Task<string> MakeRiotRequest(string method, string endpoint)
        {
            HttpResponseMessage result;

            switch (method.ToLower())
            {
                case "put":
                    result = await _httpClient.PutAsync(endpoint, null);
                    break;
                case "get":
                    result = await _httpClient.GetAsync(endpoint);
                    break;
                case "post":
                    result = await _httpClient.PostAsync(endpoint, null);
                    break;
                case "delete":
                    result = await _httpClient.DeleteAsync(endpoint);
                    break;
                default:
                    return ""; // Return empty string for unsupported methods
            }
            string resultContent = await result.Content.ReadAsStringAsync();
            return resultContent;
        }


        private async Task<string> MakeRiotRequestWithJson(string method, string endpoint, string json)
        {
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            if (method == "put")
            {
                var result = await _httpClient.PutAsync(endpoint, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                return resultContent;
            }
            return "";
        }

        internal async Task<bool> ConnectAsync()
        {
            string lockfileContent = await FindLockfilePathAsync();

            if (string.IsNullOrEmpty(lockfileContent))
                return false;
            
            var lockfileParts = lockfileContent.Split(':');
            var processName = lockfileParts[0];
            var processId = int.Parse(lockfileParts[1]);
            var authToken = lockfileParts[3];
            var lcuPort = int.Parse(lockfileParts[2]);

            _lcuBaseUrl = $"https://127.0.0.1:{lcuPort}";

            _httpClient = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true,
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.None
            });

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"riot:{authToken}")));
            return true;
        }

        internal void Disconnect()
        {
            if (_httpClient != null)
            {
                _httpClient.Dispose();
                _httpClient = null;
                return;
            }
        }

        internal async Task<Root> DeserializeRankedStatsAsync()
        {
            var rawResponse = await _httpClient.GetAsync($"{_lcuBaseUrl}/lol-ranked/v1/current-ranked-stats");
            if (!rawResponse.IsSuccessStatusCode) return null;
            var responseBody = await rawResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(responseBody);
        }
        
        internal async Task<int> GetServerRegionAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_lcuBaseUrl}/riotclient/get_region_locale");

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var regionLocaleInfo = JObject.Parse(responseBody);
                string serverRegion = regionLocaleInfo["region"].ToString();

                switch (serverRegion.ToUpper())
                {
                    case "EUW":
                        return 0;
                    case "EUNE":
                        return 1;
                    case "RU":
                        return 2;
                    case "TR":
                        return 3;
                    case "NA":
                        return 4;
                    default:
                        return -1;
                }
            }
            return -1;
        }

        internal async Task<string> GetClientStateAsync()
        {
            if (!Utils.IsClientRunning())
                return "Client not running"; 

            HttpResponseMessage response = await _httpClient.GetAsync($"{_lcuBaseUrl}/lol-gameflow/v1/gameflow-phase");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                string gameState = responseBody.Trim('"');
                if (gameState == "None")
                    return "Client Menu";

                return gameState;
            }
            return null;
        }

        internal async Task<string> GetAccountUsernameAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_lcuBaseUrl}/lol-login/v1/session");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject sessionInfo = JObject.Parse(responseBody);
                return sessionInfo["username"].ToString();
            }
            return null;
        }

        internal async Task<string> GetSummonerDisplayName()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_lcuBaseUrl}/lol-summoner/v1/current-summoner");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject summonerInfo = JObject.Parse(responseBody);
                return summonerInfo["displayName"].ToString();
            }
            return null;
        }

        internal async Task<string> FindLockfilePathAsync()
        {
            while (!Utils.IsClientRunning())
            {
                await Task.Delay(1000); // Wait for 1 second before checking again.
                Console.WriteLine("[FINDLOCKFILEPATHASYNC] - Waiting for client...");
            }

            string installDirectory = LocalClientController.ClientInfo(LocalClientController.ClientInfoType.DirectoryPath);
            string lockfilePath = Path.Combine(installDirectory, "lockfile");

            if (!File.Exists(lockfilePath))
                return null;

            using (FileStream fileStream = new FileStream(lockfilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string lockfileContent = await reader.ReadToEndAsync();
                return lockfileContent;
            }
        }
    }
}