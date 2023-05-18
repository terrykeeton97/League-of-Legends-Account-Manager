using Acccount_Manager.Classes.Data.LCUClientData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Acccount_Manager.Classes.Data
{
    public static class CredentialsService
    {
        internal static List<SummonerInfo> Credentials;

        internal static SummonerInfo GetAccount(string username)
        {
            if (Credentials == null)
                LoadCredentials();
            
            return Credentials.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.OrdinalIgnoreCase));
        }

        internal static void LoadCredentials()
        {
            if (File.Exists(Constants.accountData))
            {
                var json = File.ReadAllText(Constants.accountData);
                Credentials = JsonConvert.DeserializeObject<List<SummonerInfo>>(json);
            }
            else
            {
                Credentials = new List<SummonerInfo>();
                SaveCredentials(); // Save the empty list to create the JSON file
            }
        }

        internal static void AddOrUpdateCredentials(SummonerInfo credentials)
        {
            if (Credentials == null)
                LoadCredentials();

            if (Credentials == null)
                Credentials = new List<SummonerInfo>();

            var existingCredential = Credentials.FirstOrDefault(x => string.Equals(x.Username, credentials.Username, StringComparison.OrdinalIgnoreCase));

            if (existingCredential != null)
            {
                existingCredential.DisplayName = credentials.DisplayName;
                existingCredential.Password = credentials.Password;
                existingCredential.Server = credentials.Server;
                SaveCredentials();
                return;
            }

            credentials.DateAdded = DateTime.Now;
            Credentials.Add(credentials);
            SaveCredentials();
        }


        internal static void RemoveCredentials(string username, bool saveCredentials = true)
        {
            if (Credentials == null)
                Credentials = new List<SummonerInfo>();
            
            var currentCredential = Credentials.FirstOrDefault(credential => credential.Username == username);
            if (currentCredential == null) return;
            
            Credentials.Remove(currentCredential);
            if (saveCredentials)
                SaveCredentials();
        }

        private static void SaveCredentials()
        {
            var json = JsonConvert.SerializeObject(Credentials, Formatting.Indented);
            File.WriteAllText(Constants.accountData, json);
        }
    }
}
