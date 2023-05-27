namespace Acccount_Manager.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Directory_textBox = new System.Windows.Forms.TextBox();
            this.DirectoryBtn = new System.Windows.Forms.Button();
            this.PersistedSettings_checkBox = new System.Windows.Forms.CheckBox();
            this.English_checkBox = new System.Windows.Forms.CheckBox();
            this.StartWindows_checkBox = new System.Windows.Forms.CheckBox();
            this.AlwaysUpdate_checkBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Github_Label = new System.Windows.Forms.LinkLabel();
            this.Updates_checkBox = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Refresh_checkBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Notify_checkBox = new System.Windows.Forms.CheckBox();
            this.zeroitThinLine1 = new Zeroit.Framework.LineSeparators.ZeroitThinLine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Directory_textBox
            // 
            this.Directory_textBox.BackColor = System.Drawing.Color.White;
            this.Directory_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Directory_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Directory_textBox.Location = new System.Drawing.Point(116, 151);
            this.Directory_textBox.Name = "Directory_textBox";
            this.Directory_textBox.ReadOnly = true;
            this.Directory_textBox.Size = new System.Drawing.Size(182, 23);
            this.Directory_textBox.TabIndex = 0;
            // 
            // DirectoryBtn
            // 
            this.DirectoryBtn.Location = new System.Drawing.Point(15, 151);
            this.DirectoryBtn.Name = "DirectoryBtn";
            this.DirectoryBtn.Size = new System.Drawing.Size(95, 23);
            this.DirectoryBtn.TabIndex = 1;
            this.DirectoryBtn.Text = "Open Directory";
            this.DirectoryBtn.UseVisualStyleBackColor = true;
            this.DirectoryBtn.Click += new System.EventHandler(this.DirectoryBtn_Click);
            // 
            // PersistedSettings_checkBox
            // 
            this.PersistedSettings_checkBox.AutoSize = true;
            this.PersistedSettings_checkBox.Checked = true;
            this.PersistedSettings_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PersistedSettings_checkBox.Location = new System.Drawing.Point(15, 16);
            this.PersistedSettings_checkBox.Name = "PersistedSettings_checkBox";
            this.PersistedSettings_checkBox.Size = new System.Drawing.Size(145, 19);
            this.PersistedSettings_checkBox.TabIndex = 3;
            this.PersistedSettings_checkBox.Text = "Save Persisted Settings";
            this.PersistedSettings_checkBox.UseVisualStyleBackColor = true;
            this.PersistedSettings_checkBox.CheckedChanged += new System.EventHandler(this.PersistedSettings_checkBox_CheckedChanged);
            // 
            // English_checkBox
            // 
            this.English_checkBox.AutoSize = true;
            this.English_checkBox.Checked = true;
            this.English_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.English_checkBox.Location = new System.Drawing.Point(15, 62);
            this.English_checkBox.Name = "English_checkBox";
            this.English_checkBox.Size = new System.Drawing.Size(140, 19);
            this.English_checkBox.TabIndex = 11;
            this.English_checkBox.Text = "Keep Game In English";
            this.English_checkBox.UseVisualStyleBackColor = true;
            this.English_checkBox.CheckedChanged += new System.EventHandler(this.English_checkBox_CheckedChanged);
            // 
            // StartWindows_checkBox
            // 
            this.StartWindows_checkBox.AutoSize = true;
            this.StartWindows_checkBox.Location = new System.Drawing.Point(15, 39);
            this.StartWindows_checkBox.Name = "StartWindows_checkBox";
            this.StartWindows_checkBox.Size = new System.Drawing.Size(128, 19);
            this.StartWindows_checkBox.TabIndex = 9;
            this.StartWindows_checkBox.Text = "Start with Windows";
            this.StartWindows_checkBox.UseVisualStyleBackColor = true;
            this.StartWindows_checkBox.CheckedChanged += new System.EventHandler(this.StartWindows_checkBox_CheckedChanged);
            // 
            // AlwaysUpdate_checkBox
            // 
            this.AlwaysUpdate_checkBox.AutoSize = true;
            this.AlwaysUpdate_checkBox.Checked = true;
            this.AlwaysUpdate_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlwaysUpdate_checkBox.Location = new System.Drawing.Point(16, 43);
            this.AlwaysUpdate_checkBox.Name = "AlwaysUpdate_checkBox";
            this.AlwaysUpdate_checkBox.Size = new System.Drawing.Size(212, 19);
            this.AlwaysUpdate_checkBox.TabIndex = 10;
            this.AlwaysUpdate_checkBox.Text = "Always Update Ranked Information";
            this.AlwaysUpdate_checkBox.UseVisualStyleBackColor = true;
            this.AlwaysUpdate_checkBox.CheckedChanged += new System.EventHandler(this.AlwaysUpdate_checkBox_CheckedChanged);
            // 
            // toolTip
            // 
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 242);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DirectoryBtn);
            this.tabPage1.Controls.Add(this.Directory_textBox);
            this.tabPage1.Controls.Add(this.Github_Label);
            this.tabPage1.Controls.Add(this.Updates_checkBox);
            this.tabPage1.Controls.Add(this.English_checkBox);
            this.tabPage1.Controls.Add(this.PersistedSettings_checkBox);
            this.tabPage1.Controls.Add(this.StartWindows_checkBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GENERAL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Github_Label
            // 
            this.Github_Label.AutoSize = true;
            this.Github_Label.LinkColor = System.Drawing.Color.Black;
            this.Github_Label.Location = new System.Drawing.Point(301, 185);
            this.Github_Label.Name = "Github_Label";
            this.Github_Label.Size = new System.Drawing.Size(127, 15);
            this.Github_Label.TabIndex = 15;
            this.Github_Label.TabStop = true;
            this.Github_Label.Text = "Visit Github Repository";
            this.Github_Label.VisitedLinkColor = System.Drawing.Color.Red;
            this.Github_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_Label_LinkClicked);
            // 
            // Updates_checkBox
            // 
            this.Updates_checkBox.AutoSize = true;
            this.Updates_checkBox.Checked = true;
            this.Updates_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Updates_checkBox.Location = new System.Drawing.Point(15, 87);
            this.Updates_checkBox.Name = "Updates_checkBox";
            this.Updates_checkBox.Size = new System.Drawing.Size(202, 19);
            this.Updates_checkBox.TabIndex = 14;
            this.Updates_checkBox.Text = "Automatically Check For Updates";
            this.Updates_checkBox.UseVisualStyleBackColor = true;
            this.Updates_checkBox.CheckedChanged += new System.EventHandler(this.Updates_checkBox_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(444, 214);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "LOGS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(444, 214);
            this.listBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(444, 214);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "MORE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Refresh_checkBox);
            this.tabPage6.Controls.Add(this.numericUpDown);
            this.tabPage6.Controls.Add(this.CountLabel);
            this.tabPage6.Controls.Add(this.AlwaysUpdate_checkBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(444, 214);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "RANKED DATA";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Refresh_checkBox
            // 
            this.Refresh_checkBox.AutoSize = true;
            this.Refresh_checkBox.Checked = true;
            this.Refresh_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Refresh_checkBox.Enabled = false;
            this.Refresh_checkBox.Location = new System.Drawing.Point(16, 18);
            this.Refresh_checkBox.Name = "Refresh_checkBox";
            this.Refresh_checkBox.Size = new System.Drawing.Size(136, 19);
            this.Refresh_checkBox.TabIndex = 15;
            this.Refresh_checkBox.Text = "Show Refresh Button";
            this.Refresh_checkBox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Enabled = false;
            this.numericUpDown.Location = new System.Drawing.Point(234, 41);
            this.numericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown.TabIndex = 14;
            this.numericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Enabled = false;
            this.CountLabel.Location = new System.Drawing.Point(306, 44);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(50, 15);
            this.CountLabel.TabIndex = 12;
            this.CountLabel.Text = "minutes";
            // 
            // Notify_checkBox
            // 
            this.Notify_checkBox.AutoSize = true;
            this.Notify_checkBox.Enabled = false;
            this.Notify_checkBox.Location = new System.Drawing.Point(15, 85);
            this.Notify_checkBox.Name = "Notify_checkBox";
            this.Notify_checkBox.Size = new System.Drawing.Size(213, 19);
            this.Notify_checkBox.TabIndex = 12;
            this.Notify_checkBox.Text = "Display Notifications In System Tray";
            this.Notify_checkBox.UseVisualStyleBackColor = true;
            // 
            // zeroitThinLine1
            // 
            this.zeroitThinLine1.AllowTransparency = true;
            this.zeroitThinLine1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitThinLine1.LineColor = System.Drawing.Color.Black;
            this.zeroitThinLine1.LineWidth = 1F;
            this.zeroitThinLine1.Location = new System.Drawing.Point(-11, 80);
            this.zeroitThinLine1.Name = "zeroitThinLine1";
            this.zeroitThinLine1.Size = new System.Drawing.Size(492, 2);
            this.zeroitThinLine1.TabIndex = 16;
            this.zeroitThinLine1.Text = "zeroitThinLine1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 344);
            this.Controls.Add(this.zeroitThinLine1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Directory_textBox;
        private System.Windows.Forms.Button DirectoryBtn;
        private System.Windows.Forms.CheckBox PersistedSettings_checkBox;
        private System.Windows.Forms.CheckBox English_checkBox;
        private System.Windows.Forms.CheckBox AlwaysUpdate_checkBox;
        private System.Windows.Forms.CheckBox StartWindows_checkBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox Updates_checkBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.LinkLabel Github_Label;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.CheckBox Notify_checkBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.CheckBox Refresh_checkBox;
        private System.Windows.Forms.Label CountLabel;
        private Zeroit.Framework.LineSeparators.ZeroitThinLine zeroitThinLine1;
    }
}