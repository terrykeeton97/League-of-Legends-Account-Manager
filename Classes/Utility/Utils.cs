using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Data.LCUClientData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Acccount_Manager.Classes.Utility
{
    internal static class Utils
    {
        private static readonly Random Random = new Random();

        internal static string GenerateString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/$%^&";
            return new string(Enumerable.Repeat(chars, 16)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        private static readonly string[] ProcessNames =
        {
            "RiotClientUx",
            "RiotClientCrashHandler",
            "RiotClientUxRender",
            "LeagueClientUxRender",
            "LeagueClient",
            "LeagueCrashHandler"
        };

        private static List<int> GetLeagueProcessIds()
        {
            var processIds = new List<int>();

            foreach (var processName in ProcessNames)
            {
                var processes = Process.GetProcessesByName(processName);
                processIds.AddRange(processes.Select(process => process.Id));
            }
            return processIds;
        }

        internal static int GetProcessId(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                return processes[0].Id;
            }
            else
            {
                throw new Exception($"No process with the name {processName} is currently running.");
            }
        }

        private static void KillProcesses(List<int> processIds)
        {
            foreach (var processId in processIds)
            {
                try
                {
                    var process = Process.GetProcessById(processId);
                    if (process.HasExited) continue;

                    process.Kill();
                    process.WaitForExit();
                }
                catch (ArgumentException)
                {
                    //do nothing
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to kill processes\n{ex.Message}", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal static void KillAllLeagueProcesses()
        {
            KillProcesses(GetLeagueProcessIds());
            try
            {
                foreach (var processName in ProcessNames)
                {
                    var processes = Process.GetProcessesByName(processName);
                    foreach (var process in processes)
                    {
                        process.Kill();
                        process.WaitForExit();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unable to kill all league processes", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static bool IsClientRunning()
        {
            var processes = Process.GetProcessesByName("LeagueClient");
            return processes.Length > 0;
        }

        internal static bool IsRiotClientRunning()
        {
            var processes = Process.GetProcessesByName("RiotClientUx");
            return processes.Length > 0;
        }

        internal static long GetDirectorySize(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            try
            {
                return directoryInfo.GetFiles().Sum(file => file.Length) +
                       directoryInfo.GetDirectories().Sum(dir => GetDirectorySize(dir.FullName));
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to get directory size", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        internal static void StartClient()
        {
            string clientExePath = LocalClientController.ClientInfo(LocalClientController.ClientInfoType.LeagueClientExe);
            ProcessStartInfo clientStartInfo = new ProcessStartInfo(clientExePath);
            Process.Start(clientStartInfo);
        }

        internal static void StartAnotherClientInstance()
        {
            string riotClientServicesPath = LocalClientController.ClientInfo(LocalClientController.ClientInfoType.LeagueClientExe);
            string launchArguments = @"--launch-product=league_of_legends --launch-patchline=live --allow-multiple-clients";

            ProcessStartInfo riotClientServicesStartInfo = new ProcessStartInfo(riotClientServicesPath, launchArguments);
            Process.Start(riotClientServicesStartInfo);
        }

        internal static string GetCurrentPatch()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("http://ddragon.leagueoflegends.com/api/versions.json").Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                var array = JArray.Parse(responseContent);
                return (string)array[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to get current League of Legends patch", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        internal static void LoadAccountMapFromJson(DataGridView accountMap)
        {
            string jsonData = File.ReadAllText(Constants.accountData);
            List<SummonerInfo> accountList = JsonConvert.DeserializeObject<List<SummonerInfo>>(jsonData);

            if (accountList == null)
                return;

            accountMap.Rows.Clear();

            foreach (SummonerInfo account in accountList)
            {
                DataGridViewRow row = new DataGridViewRow();

                Dictionary<string, object> cellData = new Dictionary<string, object>()
                {
                    { "Username", account.Username },
                    { "DisplayName", account.DisplayName },
                    { "Rank", account.Provisional ? "UNRANKED" : account.Division == "NA" ? $"{account.Tier} {account.LeaguePoints}LP" : $"{account.Tier} {account.Division} {account.LeaguePoints}LP" },
                    { "Server", account.Server },
                    { "DateAdded", account.DateAdded }
                };

                foreach (KeyValuePair<string, object> data in cellData)
                {;
                    DataGridViewTextBoxCell cell = CreateCell(data.Value);
                    row.Cells.Add(cell);
                }

                accountMap.Rows.Add(row);
            }
        }

        private static DataGridViewTextBoxCell CreateCell(object value)
        {
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell
            {
                Value = value
            };
            return cell;
        }



        internal static void RunProcess(string exeName)
        {
            try
            {
                string exeFilePath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Auto Login V2"), exeName);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exeFilePath,
                    UseShellExecute = true
                };

                Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("Unable to run R3nzSkin", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task<string> GetReleaseDownloadUrl(string owner, string repo, string version)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://api.github.com/repos/{owner}/{repo}/releases/tags/{version}";
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
                client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.v3+json");

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                dynamic releaseData = JsonConvert.DeserializeObject(json);

                return releaseData.assets[0].browser_download_url;
            }
        }

        internal static async Task<string> GetLatestReleaseVersion(string owner, string repo)
        {
            string url = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "request");

                string json = await client.GetStringAsync(url);
                dynamic releaseData = JsonConvert.DeserializeObject(json);
                string version = releaseData.tag_name;
                return version;
            }
        }

        internal static async Task DownloadAndExtract(string owner, string repo, string versionFilePath)
        {
            try
            {
                string directoryPath = Constants.basePath;
                string zipFilePath = Path.Combine(directoryPath, "R3nzSkin.zip");

                string latestVersion = await GetLatestReleaseVersion(owner, repo);
                string currentVersion = File.Exists(versionFilePath) ? File.ReadAllText(versionFilePath) : null;

                string dllFilePath = Path.Combine(directoryPath, "R3nzSkin.dll");

                if (currentVersion == latestVersion && File.Exists(dllFilePath))
                    return;

                string downloadUrl = await GetReleaseDownloadUrl(owner, repo, latestVersion);

                using (WebClient client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(new Uri(downloadUrl), zipFilePath);

                    if (File.Exists(dllFilePath))
                        File.Delete(dllFilePath);

                    using (ZipArchive archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry entry = archive.GetEntry("R3nzSkin.dll");
                        entry?.ExtractToFile(Path.Combine(directoryPath, entry.Name), true);
                    }

                    File.WriteAllText(versionFilePath, latestVersion);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to download or extract R3nzSkin", GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
