using Acccount_Manager.Classes.Data;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Acccount_Manager.Classes.Utility
{
    internal class Startup
    {
        internal static void Init(Form main, DataGridView accountMap, StatusStrip toolBar)
        {
            main.Text = Utils.GenerateString();
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Auto Login V2");
            FileManager.CheckClientInfo();
            FileManager.DoFilesExist(Constants.accountData, Constants.r3nzData);
            UpdateStatusStrip(toolBar, Utils.GetCurrentPatch());
            Utils.LoadAccountMapFromJson(accountMap);
        }

        private static async void UpdateStatusStrip(StatusStrip toolBar, string currentPatch)
        {
            var patchLabel = new ToolStripLabel("Patch: " + (currentPatch ?? "UNABLE TO GET PATCH"));
            var r3nzLabel = new ToolStripLabel("R3nzSkin Version: " + await Utils.GetLatestReleaseVersion("R3nzTheCodeGOD", "R3nzSkin"));
            SetToolStripLabelColors(patchLabel, r3nzLabel);

            toolBar.Items.Add(patchLabel);
            toolBar.Items.Add(new ToolStripSeparator());
            toolBar.Items.Add(r3nzLabel);
        }

        private static void SetToolStripLabelColors(params ToolStripLabel[] labels)
        {
            foreach (var label in labels)
            {
                label.ForeColor = Color.DimGray;
            }
        }
    }
}