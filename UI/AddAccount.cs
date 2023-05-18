using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Data.LCUClientData;
using Acccount_Manager.Classes.Utility;
using System;
using System.Windows.Forms;

namespace Acccount_Manager.UI
{
    public partial class AddAccount : Form
    {
        private readonly LCU _lcuClient = new LCU();
        private DataGridView accountMap;

        public AddAccount()
        {
            InitializeComponent();
            Text = Utils.GenerateString();
        }

        public AddAccount(DataGridView dgv)
        {
            InitializeComponent();
            accountMap = dgv;
            Text = Utils.GenerateString();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(Username_textBox.Text) || string.IsNullOrWhiteSpace(Password_textBox.Text) || string.IsNullOrWhiteSpace(Summoner_textBox.Text) || string.IsNullOrWhiteSpace(Rank_textBox.Text))
                return false;         
            return true;         
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            var root = await _lcuClient.DeserializeRankedStatsAsync();
            var rankedEntry = root.highestRankedEntry;

            if (!ValidateForm())
            {
                MessageBox.Show("Please fill out all of the fields");
                return;
            }

            var credentials = new SummonerInfo
            {
                Username = Username_textBox.Text,
                DisplayName = Summoner_textBox.Text,
                Password = Password_textBox.Text,
                Server = Server_comboBox.Text,
                DateAdded = DateTime.Now,
                Tier = rankedEntry.tier,
                Division = rankedEntry.division,
                LeaguePoints = rankedEntry.leaguePoints,
                Wins = rankedEntry.wins,
                Losses = rankedEntry.losses,
                DaysUntilDecay = rankedEntry.warnings?.daysUntilDecay,
                Provisional = rankedEntry.isProvisional
            };

            CredentialsService.AddOrUpdateCredentials(credentials);
            MessageBox.Show("Credentials added successfully!");
            _lcuClient.Disconnect();
            Utils.LoadAccountMapFromJson(accountMap);
        }

        internal async void AddAccount_Load(object sender, EventArgs e)
        {
            if (Utils.IsClientRunning())
            {
                await _lcuClient.ConnectAsync();
                var root = await _lcuClient.DeserializeRankedStatsAsync();
                Rank_textBox.Text = $"{root.highestRankedEntry.tier} {root.highestRankedEntry.division} {root.highestRankedEntry.leaguePoints}LP";
                Summoner_textBox.Text = await _lcuClient.GetSummonerDisplayName();
                Username_textBox.Text = await _lcuClient.GetAccountUsernameAsync();
                int serverRegionIndex = await _lcuClient.GetServerRegionAsync();
                if (serverRegionIndex >= 0)
                {
                    Server_comboBox.SelectedIndex = serverRegionIndex;
                }
                return;
            }
            MessageBox.Show("League client not detected, please open the client", Utils.GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}
