using Microsoft.Win32;
using System.IO;

namespace Acccount_Manager.Classes.Utility
{
    class LocalClientController
    {
        internal enum ClientInfoType
        {
            DirectoryPath,
            LeagueClientSettings,
            GameCfg,
            LCUAccountPreferences,
            LCULocalPreferences,
            PerksPerferences,
            PersistedSettings,
            LeagueClientExe,
            Logs
        }

        internal static string ClientInfo(ClientInfoType type)
        {
            var reg = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\Riot Game league_of_legends.live", "InstallLocation", null);
            string path = "";
            switch (type)
            {
                case ClientInfoType.LeagueClientExe:
                    path = Path.Combine(reg.ToString(), "LeagueClient.exe");
                    break;
                case ClientInfoType.LeagueClientSettings:
                    path = Path.Combine(reg.ToString(), "Config", "LeagueClientSettings.yaml");
                    break;
                case ClientInfoType.GameCfg:
                    path = Path.Combine(reg.ToString(), "Config", "game.cfg");
                    break;
                case ClientInfoType.LCUAccountPreferences:
                    path = Path.Combine(reg.ToString(), "Config", "LCUAccountPreferences.yaml");
                    break;
                case ClientInfoType.LCULocalPreferences:
                    path = Path.Combine(reg.ToString(), "Config", "LCULocalPreferences.yaml");
                    break;
                case ClientInfoType.PerksPerferences:
                    path = Path.Combine(reg.ToString(), "Config", "PerksPreferences.yaml");
                    break;
                case ClientInfoType.PersistedSettings:
                    path = Path.Combine(reg.ToString(), "Config", "PersistedSettings.json");
                    break;
                case ClientInfoType.Logs:
                    path = reg.ToString() + @"\Logs";
                    break;
                case ClientInfoType.DirectoryPath:
                    path = reg.ToString();
                    break;
            }
            return path;
        }
    }
}
