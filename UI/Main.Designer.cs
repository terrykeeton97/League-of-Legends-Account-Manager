namespace Account_Manager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AccountMap = new System.Windows.Forms.DataGridView();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClientLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTemoraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disenchantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massDisenchantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamProofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceCloseClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lobbyRevealbannableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatusStripContainer = new System.Windows.Forms.StatusStrip();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.utilities = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.streamProof = new System.Windows.Forms.ToolStripMenuItem();
            this.forceCloseClients = new System.Windows.Forms.ToolStripMenuItem();
            this.startAnotherClientInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.loadR3nzSkinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.account = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.testLoginAccount1RUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testLoginAccount2EUWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RankedDataTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AccountMap)).BeginInit();
            this.SatusStripContainer.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountMap
            // 
            this.AccountMap.AllowUserToAddRows = false;
            this.AccountMap.AllowUserToDeleteRows = false;
            this.AccountMap.AllowUserToResizeColumns = false;
            this.AccountMap.AllowUserToResizeRows = false;
            this.AccountMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AccountMap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AccountMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AccountMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameColumn,
            this.summonerNameColumn,
            this.rankColumn,
            this.serverColumn,
            this.dateColumn});
            this.AccountMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountMap.GridColor = System.Drawing.SystemColors.Control;
            this.AccountMap.Location = new System.Drawing.Point(0, 24);
            this.AccountMap.MultiSelect = false;
            this.AccountMap.Name = "AccountMap";
            this.AccountMap.RowHeadersVisible = false;
            this.AccountMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AccountMap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AccountMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountMap.ShowCellErrors = false;
            this.AccountMap.ShowCellToolTips = false;
            this.AccountMap.ShowEditingIcon = false;
            this.AccountMap.Size = new System.Drawing.Size(797, 279);
            this.AccountMap.TabIndex = 1;
            // 
            // usernameColumn
            // 
            this.usernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            this.usernameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // summonerNameColumn
            // 
            this.summonerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.summonerNameColumn.HeaderText = "Summoner Name";
            this.summonerNameColumn.Name = "summonerNameColumn";
            this.summonerNameColumn.ReadOnly = true;
            this.summonerNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rankColumn
            // 
            this.rankColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rankColumn.HeaderText = "Rank";
            this.rankColumn.Name = "rankColumn";
            this.rankColumn.ReadOnly = true;
            this.rankColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // serverColumn
            // 
            this.serverColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serverColumn.HeaderText = "Server";
            this.serverColumn.Name = "serverColumn";
            this.serverColumn.ReadOnly = true;
            this.serverColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateColumn
            // 
            this.dateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateColumn.HeaderText = "Date Added";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.AutoSize = false;
            this.optionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingMenuItem,
            this.utilitiesMenuItem,
            this.exitMenuItem});
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsMenuItem.Text = "Options";
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.Name = "settingMenuItem";
            this.settingMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingMenuItem.Text = "Settings";
            // 
            // utilitiesMenuItem
            // 
            this.utilitiesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearClientLogsToolStripMenuItem,
            this.clearTemoraryToolStripMenuItem,
            this.disenchantToolStripMenuItem,
            this.massDisenchantToolStripMenuItem,
            this.streamProofToolStripMenuItem,
            this.forceCloseClientsToolStripMenuItem,
            this.lobbyRevealbannableToolStripMenuItem});
            this.utilitiesMenuItem.Name = "utilitiesMenuItem";
            this.utilitiesMenuItem.Size = new System.Drawing.Size(116, 22);
            this.utilitiesMenuItem.Text = "Utilities";
            // 
            // clearClientLogsToolStripMenuItem
            // 
            this.clearClientLogsToolStripMenuItem.Name = "clearClientLogsToolStripMenuItem";
            this.clearClientLogsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            // 
            // clearTemoraryToolStripMenuItem
            // 
            this.clearTemoraryToolStripMenuItem.Name = "clearTemoraryToolStripMenuItem";
            this.clearTemoraryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clearTemoraryToolStripMenuItem.Text = "Clear Temporary Files";
            // 
            // disenchantToolStripMenuItem
            // 
            this.disenchantToolStripMenuItem.Name = "disenchantToolStripMenuItem";
            this.disenchantToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.disenchantToolStripMenuItem.Text = "Dodge Lobby";
            // 
            // massDisenchantToolStripMenuItem
            // 
            this.massDisenchantToolStripMenuItem.Name = "massDisenchantToolStripMenuItem";
            this.massDisenchantToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.massDisenchantToolStripMenuItem.Text = "Mass Disenchant";
            // 
            // streamProofToolStripMenuItem
            // 
            this.streamProofToolStripMenuItem.Name = "streamProofToolStripMenuItem";
            this.streamProofToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            // 
            // forceCloseClientsToolStripMenuItem
            // 
            this.forceCloseClientsToolStripMenuItem.Name = "forceCloseClientsToolStripMenuItem";
            this.forceCloseClientsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            // 
            // lobbyRevealbannableToolStripMenuItem
            // 
            this.lobbyRevealbannableToolStripMenuItem.Enabled = false;
            this.lobbyRevealbannableToolStripMenuItem.Name = "lobbyRevealbannableToolStripMenuItem";
            this.lobbyRevealbannableToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lobbyRevealbannableToolStripMenuItem.Text = "Lobby Reveal (bannable)";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(116, 22);
            // 
            // accountMenuItem
            // 
            this.accountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem});
            this.accountMenuItem.Name = "accountMenuItem";
            this.accountMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountMenuItem.Text = "Account";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadMenuItem.Text = "Load";
            // 
            // SatusStripContainer
            // 
            this.SatusStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerLabel});
            this.SatusStripContainer.Location = new System.Drawing.Point(0, 281);
            this.SatusStripContainer.Name = "SatusStripContainer";
            this.SatusStripContainer.Size = new System.Drawing.Size(797, 22);
            this.SatusStripContainer.SizingGrip = false;
            this.SatusStripContainer.TabIndex = 3;
            this.SatusStripContainer.Text = "StatusStripContainer";
            // 
            // options
            // 
            this.options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.utilities,
            this.exit});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(61, 20);
            this.options.Text = "Options";
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(117, 22);
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // utilities
            // 
            this.utilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogs,
            this.streamProof,
            this.forceCloseClients,
            this.startAnotherClientInstanceMenuItem,
            this.launchClient,
            this.loadR3nzSkinMenuItem});
            this.utilities.Name = "utilities";
            this.utilities.Size = new System.Drawing.Size(117, 22);
            this.utilities.Text = "Utilities";
            // 
            // clearLogs
            // 
            this.clearLogs.Name = "clearLogs";
            this.clearLogs.Size = new System.Drawing.Size(226, 22);
            this.clearLogs.Text = "Clear Client Logs";
            this.clearLogs.Click += new System.EventHandler(this.ClearLogs_Click);
            // 
            // streamProof
            // 
            this.streamProof.Name = "streamProof";
            this.streamProof.Size = new System.Drawing.Size(226, 22);
            this.streamProof.Text = "Stream Proof";
            this.streamProof.Click += new System.EventHandler(this.StreamProof_Click);
            // 
            // forceCloseClients
            // 
            this.forceCloseClients.Name = "forceCloseClients";
            this.forceCloseClients.Size = new System.Drawing.Size(226, 22);
            this.forceCloseClients.Text = "Force Close Clients";
            this.forceCloseClients.Click += new System.EventHandler(this.ForceCloseClients_Click);
            // 
            // startAnotherClientInstanceMenuItem
            // 
            this.startAnotherClientInstanceMenuItem.Name = "startAnotherClientInstanceMenuItem";
            this.startAnotherClientInstanceMenuItem.Size = new System.Drawing.Size(226, 22);
            this.startAnotherClientInstanceMenuItem.Text = "Start Another Client Instance";
            this.startAnotherClientInstanceMenuItem.Click += new System.EventHandler(this.StartAnotherClientInstanceMenuItem_Click);
            // 
            // launchClient
            // 
            this.launchClient.Name = "launchClient";
            this.launchClient.Size = new System.Drawing.Size(226, 22);
            this.launchClient.Text = "Launch Client";
            this.launchClient.Click += new System.EventHandler(this.LaunchClient_Click);
            // 
            // loadR3nzSkinMenuItem
            // 
            this.loadR3nzSkinMenuItem.Name = "loadR3nzSkinMenuItem";
            this.loadR3nzSkinMenuItem.Size = new System.Drawing.Size(226, 22);
            this.loadR3nzSkinMenuItem.Text = "Load R3nzSkin";
            this.loadR3nzSkinMenuItem.Click += new System.EventHandler(this.LoadR3nzSkinMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(117, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // account
            // 
            this.account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccount,
            this.removeAccount});
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(64, 20);
            this.account.Text = "Account";
            // 
            // addAccount
            // 
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(165, 22);
            this.addAccount.Text = "Add Account";
            this.addAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // removeAccount
            // 
            this.removeAccount.Name = "removeAccount";
            this.removeAccount.Size = new System.Drawing.Size(165, 22);
            this.removeAccount.Text = "Remove Account";
            this.removeAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(45, 20);
            this.load.Text = "Load";
            this.load.Click += new System.EventHandler(this.Load_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.options,
            this.account,
            this.load});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(797, 24);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.Text = "ToolBar";
            // 
            // testLoginAccount1RUToolStripMenuItem
            // 
            this.testLoginAccount1RUToolStripMenuItem.Name = "testLoginAccount1RUToolStripMenuItem";
            this.testLoginAccount1RUToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // testLoginAccount2EUWToolStripMenuItem
            // 
            this.testLoginAccount2EUWToolStripMenuItem.Name = "testLoginAccount2EUWToolStripMenuItem";
            this.testLoginAccount2EUWToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // RankedDataTimer
            // 
            this.RankedDataTimer.Interval = 600000;
            this.RankedDataTimer.Tick += new System.EventHandler(this.RankedDataTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 303);
            this.Controls.Add(this.SatusStripContainer);
            this.Controls.Add(this.AccountMap);
            this.Controls.Add(this.ToolBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolBar;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AccountMap)).EndInit();
            this.SatusStripContainer.ResumeLayout(false);
            this.SatusStripContainer.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountMap;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearClientLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTemoraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disenchantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massDisenchantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamProofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceCloseClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lobbyRevealbannableToolStripMenuItem;
        private System.Windows.Forms.StatusStrip SatusStripContainer;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem utilities;
        private System.Windows.Forms.ToolStripMenuItem clearLogs;
        private System.Windows.Forms.ToolStripMenuItem streamProof;
        private System.Windows.Forms.ToolStripMenuItem forceCloseClients;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem account;
        private System.Windows.Forms.ToolStripMenuItem addAccount;
        private System.Windows.Forms.ToolStripMenuItem removeAccount;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem launchClient;
        private System.Windows.Forms.ToolStripMenuItem testLoginAccount1RUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testLoginAccount2EUWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadR3nzSkinMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summonerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.ToolStripMenuItem startAnotherClientInstanceMenuItem;
        private System.Windows.Forms.Timer RankedDataTimer;
        private System.Windows.Forms.ToolStripStatusLabel timerLabel;
    }
}

