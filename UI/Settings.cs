using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Utility;
using Account_Manager.Classes.Utility;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Acccount_Manager.UI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Logger.Initialize(listBox);
            Text = Utils.GenerateString();
            Directory_textBox.Text = Constants.basePath;
            PersistedSettings_checkBox.Checked = Account_Manager.Properties.Settings.Default.persistedSettings;
            StartWindows_checkBox.Checked = Account_Manager.Properties.Settings.Default.startWindows;
            AlwaysUpdate_checkBox.Checked = Account_Manager.Properties.Settings.Default.updateInformation;
            English_checkBox.Checked = Account_Manager.Properties.Settings.Default.keepEnglish;
            Updates_checkBox.Checked = Account_Manager.Properties.Settings.Default.checkForUpdates;

            if (Account_Manager.Properties.Settings.Default.updateInformation)
            {
                numericUpDown.Value = Account_Manager.Properties.Settings.Default.count;
                numericUpDown.Enabled = true;
                CountLabel.Enabled = true;
            }

            Logger.LogEvent("Settings form initialized successfully");
        }

        private void DirectoryBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Constants.basePath);
            Logger.LogEvent("Directory opened");
        }

        private void PersistedSettings_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.persistedSettings = PersistedSettings_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
            Logger.LogEvent("Persisted settings saved");
        }

        private void StartWindows_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.startWindows = StartWindows_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();

            string executablePath = Application.ExecutablePath;
            string executableFileName = Path.GetFileNameWithoutExtension(executablePath);
            string registryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey runKey = currentUserKey.OpenSubKey(registryKeyPath, true);

            if (StartWindows_checkBox.Checked)
            {
                runKey.SetValue(executableFileName, executablePath, RegistryValueKind.String);
                Logger.LogEvent("Start with windows added to the registry successfully");
            }
            else
            {
                if (runKey.GetValue(executableFileName) != null)
                {
                    runKey.DeleteValue(executableFileName);
                    Logger.LogEvent("Start with windows removed from the registry successfully");
                }
            }
            runKey.Close();
        }

        private void AlwaysUpdate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.updateInformation = AlwaysUpdate_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
            Logger.LogEvent($"Always update settings saved");
            Logger.LogEvent($"Always update check changed | {AlwaysUpdate_checkBox.Checked}");
            if (AlwaysUpdate_checkBox.Checked)
            {
                numericUpDown.Enabled = true;
                CountLabel.Enabled = true;
                return;
            }
            numericUpDown.Enabled = false;
            CountLabel.Enabled = false;
        }

        private void English_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.keepEnglish = English_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
            Logger.LogEvent($"Keep in English check changed| {English_checkBox.Checked}");
        }

        private void Updates_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.checkForUpdates = Updates_checkBox.Checked;
            Account_Manager.Properties.Settings.Default.Save();
            Logger.LogEvent($"Check for updates check changed | {Updates_checkBox.Checked}");
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Account_Manager.Properties.Settings.Default.count = (int)numericUpDown.Value;
            Account_Manager.Properties.Settings.Default.Save();
            string logMessage = $"Updating every {numericUpDown.Value} minutes";
            Logger.LogEvent(logMessage);
        }

        private void Github_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/terrykeeton97/League-of-Legends-Account-Manager");
        }
    }
}
