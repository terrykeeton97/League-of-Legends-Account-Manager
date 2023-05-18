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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.English_checkBox = new System.Windows.Forms.CheckBox();
            this.AlwaysUpdate_checkBox = new System.Windows.Forms.CheckBox();
            this.StartWindows_checkBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Directory_textBox
            // 
            this.Directory_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Directory_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Directory_textBox.Location = new System.Drawing.Point(107, 21);
            this.Directory_textBox.Name = "Directory_textBox";
            this.Directory_textBox.ReadOnly = true;
            this.Directory_textBox.Size = new System.Drawing.Size(308, 22);
            this.Directory_textBox.TabIndex = 0;
            // 
            // DirectoryBtn
            // 
            this.DirectoryBtn.Location = new System.Drawing.Point(6, 21);
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
            this.PersistedSettings_checkBox.Location = new System.Drawing.Point(6, 50);
            this.PersistedSettings_checkBox.Name = "PersistedSettings_checkBox";
            this.PersistedSettings_checkBox.Size = new System.Drawing.Size(143, 17);
            this.PersistedSettings_checkBox.TabIndex = 3;
            this.PersistedSettings_checkBox.Text = "Save Persisted Settings";
            this.PersistedSettings_checkBox.UseVisualStyleBackColor = true;
            this.PersistedSettings_checkBox.CheckedChanged += new System.EventHandler(this.PersistedSettings_checkBox_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.English_checkBox);
            this.groupBox.Controls.Add(this.AlwaysUpdate_checkBox);
            this.groupBox.Controls.Add(this.StartWindows_checkBox);
            this.groupBox.Controls.Add(this.DirectoryBtn);
            this.groupBox.Controls.Add(this.PersistedSettings_checkBox);
            this.groupBox.Controls.Add(this.Directory_textBox);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(425, 144);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Settings and Encryption";
            // 
            // English_checkBox
            // 
            this.English_checkBox.AutoSize = true;
            this.English_checkBox.Checked = true;
            this.English_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.English_checkBox.Location = new System.Drawing.Point(6, 119);
            this.English_checkBox.Name = "English_checkBox";
            this.English_checkBox.Size = new System.Drawing.Size(91, 17);
            this.English_checkBox.TabIndex = 11;
            this.English_checkBox.Text = "Keep English";
            this.English_checkBox.UseVisualStyleBackColor = true;
            this.English_checkBox.CheckedChanged += new System.EventHandler(this.English_checkBox_CheckedChanged);
            // 
            // AlwaysUpdate_checkBox
            // 
            this.AlwaysUpdate_checkBox.AutoSize = true;
            this.AlwaysUpdate_checkBox.Checked = true;
            this.AlwaysUpdate_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlwaysUpdate_checkBox.Location = new System.Drawing.Point(6, 96);
            this.AlwaysUpdate_checkBox.Name = "AlwaysUpdate_checkBox";
            this.AlwaysUpdate_checkBox.Size = new System.Drawing.Size(165, 17);
            this.AlwaysUpdate_checkBox.TabIndex = 10;
            this.AlwaysUpdate_checkBox.Text = "Always Update Information";
            this.AlwaysUpdate_checkBox.UseVisualStyleBackColor = true;
            this.AlwaysUpdate_checkBox.CheckedChanged += new System.EventHandler(this.AlwaysUpdate_checkBox_CheckedChanged);
            // 
            // StartWindows_checkBox
            // 
            this.StartWindows_checkBox.AutoSize = true;
            this.StartWindows_checkBox.Location = new System.Drawing.Point(6, 73);
            this.StartWindows_checkBox.Name = "StartWindows_checkBox";
            this.StartWindows_checkBox.Size = new System.Drawing.Size(124, 17);
            this.StartWindows_checkBox.TabIndex = 9;
            this.StartWindows_checkBox.Text = "Start with Windows";
            this.StartWindows_checkBox.UseVisualStyleBackColor = true;
            this.StartWindows_checkBox.CheckedChanged += new System.EventHandler(this.StartWindows_checkBox_CheckedChanged);
            // 
            // toolTip
            // 
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 162);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Directory_textBox;
        private System.Windows.Forms.Button DirectoryBtn;
        private System.Windows.Forms.CheckBox PersistedSettings_checkBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox English_checkBox;
        private System.Windows.Forms.CheckBox AlwaysUpdate_checkBox;
        private System.Windows.Forms.CheckBox StartWindows_checkBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}