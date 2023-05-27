using Acccount_Manager.Classes.Data;
using Account_Manager;
using Account_Manager.Classes.Utility;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acccount_Manager.Classes.Utility
{
    internal class Startup
    {
        private static bool updateReady;

        internal static async void Init(Form main, StatusStrip toolBar)
        {
            main.Text = Utils.GenerateString();
            main.MaximizeBox = false;
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Auto Login V2");
            FileManager.CheckClientInfo();
            FileManager.DoFilesExist(Constants.accountData, Constants.r3nzData);
            Utils.LoadAccountMapFromJson(Main.accountMap);

            if (Account_Manager.Properties.Settings.Default.checkForUpdates)
                if (await CheckForUpdates())
                    updateReady = true;

            UpdateStatusStrip(toolBar, Utils.GetCurrentPatch());
        }

        private static async Task<bool> CheckForUpdates()
        {
            var gitVersionString = await Utils.GetLatestReleaseVersion("terrykeeton97", "League-of-Legends-Account-Manager");
            Assembly assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version;
            var gitVersion = new Version(gitVersionString);
            return version != gitVersion;
        }

        private static async void UpdateStatusStrip(StatusStrip toolBar, string currentPatch)
        {
            var patchLabel = new ToolStripLabel("Patch: " + (currentPatch ?? "UNABLE TO GET PATCH"));
            var r3nzLabel = new ToolStripLabel("R3nzSkin Version: " + await Utils.GetLatestReleaseVersion("R3nzTheCodeGOD", "R3nzSkin"));
            var updateLabel = new ToolStripLabel("NEW UPDATE READY");
            SetToolStripLabelColors(patchLabel, r3nzLabel);

            toolBar.Items.Add(patchLabel);
            toolBar.Items.Add(new ToolStripSeparator());
            toolBar.Items.Add(r3nzLabel);

            if (updateReady)
            {
                toolBar.Items.Add(new ToolStripSeparator());
                toolBar.Items.Add(updateLabel);

                // Make the label clickable
                updateLabel.Click += (sender, e) =>
                {
                    Process.Start("https://github.com/terrykeeton97/League-of-Legends-Account-Manager");
                };

                // Start flashing the label
                FlashLabel(updateLabel);
            }
        }

        private static void SetToolStripLabelColors(params ToolStripLabel[] labels)
        {
            foreach (var label in labels)
            {
                label.ForeColor = Color.DimGray;
            }
        }

        private static async void FlashLabel(ToolStripLabel label)
        {
            Color[] colors = { Color.Red, Color.DarkOrange };
            int currentIndex = 0;

            while (true)
            {
                label.ForeColor = colors[currentIndex];
                await Task.Delay(500);
                currentIndex = (currentIndex + 1) % colors.Length;
            }
        }
    }
}