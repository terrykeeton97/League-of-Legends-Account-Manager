using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Utility;
using System.Diagnostics;
using System.Windows.Forms;

namespace Acccount_Manager.UI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Text = Utils.GenerateString();
            Directory_textBox.Text = Constants.basePath;

            PersistedSettings_checkBox.Checked = Account_Manager.Properties.Settings.Default.persistedSettings;
            StartWindows_checkBox.Checked = Account_Manager.Properties.Settings.Default.startWindows;
            AlwaysUpdate_checkBox.Checked = Account_Manager.Properties.Settings.Default.updateInformation;
            English_checkBox.Checked = Account_Manager.Properties.Settings.Default.keepEnglish;
        }

        private void DirectoryBtn_Click(object sender, System.EventArgs e)
        {
            Process.Start("explorer.exe", Constants.basePath);
        }

        private void PersistedSettings_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.persistedSettings = PersistedSettings_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
        }

        private void StartWindows_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.startWindows = StartWindows_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
        }

        private void AlwaysUpdate_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.updateInformation = AlwaysUpdate_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
        }

        private void English_checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.keepEnglish = English_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
        }
    }
}
