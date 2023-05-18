using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using static Acccount_Manager.Classes.Data.Yaml.LeagueClientSettings;
using static Acccount_Manager.Classes.Utility.LocalClientController;

namespace Acccount_Manager.Classes.Utility
{
    internal class FileManager
    {
        internal static void SetGameSettingsAndAttributes(string region)
        {
            try
            {
                var gameCfgFilePath = ClientInfo(ClientInfoType.GameCfg);
                var persistedSettingsFilePath = ClientInfo(ClientInfoType.PersistedSettings);
                var leagueClientSettingsFilePath = ClientInfo(ClientInfoType.LeagueClientSettings);

                if (Account_Manager.Properties.Settings.Default.persistedSettings)
                {
                    File.SetAttributes(gameCfgFilePath, FileAttributes.ReadOnly);
                    File.SetAttributes(persistedSettingsFilePath, FileAttributes.ReadOnly);
                }
                else
                {
                    File.SetAttributes(gameCfgFilePath, FileAttributes.Normal);
                    File.SetAttributes(persistedSettingsFilePath, FileAttributes.Normal);
                }

                if (Account_Manager.Properties.Settings.Default.keepEnglish)
                {
                    var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
                    var serializer = new SerializerBuilder().Build();
                    var settings = deserializer.Deserialize<YamlObject>(File.ReadAllText(leagueClientSettingsFilePath));
                    settings.Install.Globals.Region = region;
                    settings.Install.Globals.Locale = "en_GB";
                    File.WriteAllText(leagueClientSettingsFilePath, serializer.Serialize(settings));
                }
            }
            catch
            {
                MessageBox.Show("Unable to set game and attribute settings", Utils.GenerateString(),MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void DoFilesExist(params string[] filePaths)
        {
            try
            {
                foreach (var filePath in filePaths)
                {
                    if (!File.Exists(filePath))
                        File.Create(filePath).Close();                
                }
            }
            catch
            {
                MessageBox.Show("Unable to check or create files", Utils.GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void CheckClientInfo()
        {
            var checks = new List<(ClientInfoType, string)>
            {
                (ClientInfoType.DirectoryPath, "the LoL directory"),
                (ClientInfoType.GameCfg, "your game.cfg config file (you need to play a custom game to generate the file)"),
                (ClientInfoType.LeagueClientExe, "LeagueClient.exe"),
                (ClientInfoType.LeagueClientSettings, "LeagueClientSettings.yaml"),
                (ClientInfoType.LCUAccountPreferences, "LCUAccountPreferences.yaml"),
                (ClientInfoType.LCULocalPreferences, "LCULocalPreferences.yaml"),
                (ClientInfoType.PerksPerferences, "PerksPreferences.yaml"),
                (ClientInfoType.PersistedSettings, "PersistedSettings.json"),
            };

            foreach (var (infoType, fileDescription) in checks)
            {
                string filePath = ClientInfo(infoType);
                if (FileOrDirectoryExists(filePath))
                    continue;           

                string errorMessage = $"Unable to locate {fileDescription}.";
                var result = MessageBox.Show($"{errorMessage} Do you want to ignore and continue?\n\nThis might cause some unhandled errors.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.No)
                    Environment.Exit(0);      
            }
        }

        private static bool FileOrDirectoryExists(string path)
        {
            return File.Exists(path) || Directory.Exists(path);
        }
    }
}
