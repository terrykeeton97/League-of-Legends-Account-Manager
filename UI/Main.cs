using Acccount_Manager.Classes;
using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Data.LCUClientData;
using Acccount_Manager.Classes.Utility;
using Acccount_Manager.UI;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Account_Manager
{
    internal partial class Main : Form
    {
        private static bool isNewInstance;
        private static readonly Mutex mutex = new Mutex(true, "Auto Login V2", out isNewInstance);

        internal Main()
        {
            InitializeComponent();
            Startup.Init(this, AccountMap, SatusStripContainer);

            if (isNewInstance) //check to see if another application is open before we open this. we don't want to confuse the lcu api with the riot client.
            {
                mutex.ReleaseMutex();
                return;
            }
            MessageBox.Show("Program is already open in another instance, close that first.", Utils.GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ClearLogs_Click(object sender, EventArgs e)
        {
            string logsDirectory = LocalClientController.ClientInfo(LocalClientController.ClientInfoType.Logs);
            long sizeBefore = Utils.GetDirectorySize(logsDirectory);
            try
            {
                if (Directory.Exists(logsDirectory))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(logsDirectory);

                    foreach (FileInfo file in directoryInfo.GetFiles())
                        file.Delete();

                    foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                        dir.Delete(true);

                    long sizeAfter = Utils.GetDirectorySize(logsDirectory);

                    var kbRemoved = (sizeBefore - sizeAfter) / 1024.0;
                    MessageBox.Show($"{kbRemoved:0.##}KB of space has been removed", "Log Cleaner");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to delete logs\n{ex.Message}", "Error");
            }
        }

        private void StreamProof_Click(object sender, EventArgs e)
        {
            streamProof.Checked = !streamProof.Checked;
            IntPtr hWnd = Handle;
            Imports.SetWindowLong(hWnd, Imports.GWL_EXSTYLE, Imports.GetWindowLong(hWnd, Imports.GWL_EXSTYLE) ^ Imports.WS_EX_TOOLWINDOW);
            Imports.SetWindowDisplayAffinity(hWnd, streamProof.Checked ? Imports.WDA_MONITOR | Imports.WDA_EXCLUDEFROMCAPTURE : 0);
        }

        private void ForceCloseClients_Click(object sender, EventArgs e)
        {
            Utils.KillAllLeagueProcesses();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            using (AddAccount addAccount = new AddAccount(AccountMap))
            {
                addAccount.ShowDialog();
            }        
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            using (RemoveAccount removeAccount = new RemoveAccount())
            {
                removeAccount.ShowDialog();
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            using (Settings settings = new Settings())
            {
                settings.ShowDialog();
            }
        }

        private void LaunchClient_Click(object sender, EventArgs e)
        {
            Utils.StartClient();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            LCU leagueClient = new LCU();
            if (Utils.IsClientRunning())
            {
                leagueClient.Disconnect();
            }
        }

        private async void Load_Click(object sender, EventArgs e)
        {
            LCU leagueClient = new LCU();

            if (AccountMap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AccountMap.SelectedRows[0];
                string username = selectedRow.Cells["usernameColumn"].Value.ToString();
                var account = CredentialsService.GetAccount(username);

                FileManager.SetGameSettingsAndAttributes(account.Server);
                await leagueClient.Login(account.Username, account.Password);

                leagueClient.Disconnect();
                return;
            }

            MessageBox.Show("You have not selected an account to load", Utils.GenerateString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private async void LoadR3nzSkinMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                await Utils.DownloadAndExtract("R3nzTheCodeGOD", "R3nzSkin", Constants.r3nzData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return;
            }
            Injector injector = new Injector();
            injector.Show();
        }

        private void StartAnotherClientInstanceMenuItem_Click(object sender, EventArgs e)
        {
            Utils.StartAnotherClientInstance();
        }
    }
}
