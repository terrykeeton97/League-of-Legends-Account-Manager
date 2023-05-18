namespace Acccount_Manager.UI
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Rank_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Summoner_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Server_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.ClientTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_textBox
            // 
            this.Username_textBox.Enabled = false;
            this.Username_textBox.Location = new System.Drawing.Point(71, 20);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(217, 22);
            this.Username_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Rank_textBox);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.Summoner_textBox);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.AddBtn);
            this.GroupBox.Controls.Add(this.Server_comboBox);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.Password_textBox);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.Username_textBox);
            this.GroupBox.Location = new System.Drawing.Point(6, 5);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(299, 162);
            this.GroupBox.TabIndex = 2;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Add Account";
            // 
            // Rank_textBox
            // 
            this.Rank_textBox.Enabled = false;
            this.Rank_textBox.Location = new System.Drawing.Point(71, 104);
            this.Rank_textBox.Name = "Rank_textBox";
            this.Rank_textBox.Size = new System.Drawing.Size(217, 22);
            this.Rank_textBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Summoner";
            // 
            // Summoner_textBox
            // 
            this.Summoner_textBox.Enabled = false;
            this.Summoner_textBox.Location = new System.Drawing.Point(71, 76);
            this.Summoner_textBox.Name = "Summoner_textBox";
            this.Summoner_textBox.Size = new System.Drawing.Size(217, 22);
            this.Summoner_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(213, 132);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 21);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Server_comboBox
            // 
            this.Server_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Server_comboBox.Enabled = false;
            this.Server_comboBox.FormattingEnabled = true;
            this.Server_comboBox.Items.AddRange(new object[] {
            "EUW",
            "EUNE",
            "RU",
            "TR",
            "NA"});
            this.Server_comboBox.Location = new System.Drawing.Point(71, 132);
            this.Server_comboBox.Name = "Server_comboBox";
            this.Server_comboBox.Size = new System.Drawing.Size(136, 21);
            this.Server_comboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(71, 48);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(217, 22);
            this.Password_textBox.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 0;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 171);
            this.Controls.Add(this.GroupBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox Server_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Summoner_textBox;
        private System.Windows.Forms.Timer ClientTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rank_textBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}