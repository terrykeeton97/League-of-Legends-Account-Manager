using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Utility;
using System;
using System.Threading.Tasks;

namespace Account_Manager.Classes.Data
{
    internal class RankedData
    {
        internal async Task UpdateRankedInfo(string username)
        {
            var lcu = Main.lcu;
            var account = CredentialsService.GetAccount(username);
            if (account == null)
            {
                Console.WriteLine($"Account with username '{username}' does not exist.");
                return;
            }

            try
            {
                var rankedStats = await lcu.DeserializeRankedStatsAsync();
                var rankedEntry = rankedStats?.highestRankedEntry;

                if (rankedEntry != null)
                {
                    account.Tier = rankedEntry.tier;
                    account.Division = rankedEntry.division;
                    account.LeaguePoints = rankedEntry.leaguePoints;
                    account.Wins = rankedEntry.wins;
                    account.Losses = rankedEntry.losses;
                    account.DaysUntilDecay = rankedEntry.warnings?.daysUntilDecay;
                    account.Provisional = rankedEntry.isProvisional;

                    CredentialsService.SaveCredentials();
                    Utils.LoadAccountMapFromJson(Main.accountMap);
                    Console.WriteLine($"Ranked info updated for account '{account.Username}'.");
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve ranked info for account '{account.Username}'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update ranked info for account '{account.Username}': {ex.Message}");
            }
        }
    }
}