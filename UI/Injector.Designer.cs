namespace Acccount_Manager.UI
{
    partial class Injector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injector));
            this.InjectorBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InjectorStatus_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LeagueGameStatus_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InjectStatus_textBox = new System.Windows.Forms.TextBox();
            this.R3nzSkin_Label = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InjectorBtn
            // 
            this.InjectorBtn.BackColor = System.Drawing.Color.Red;
            this.InjectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InjectorBtn.ForeColor = System.Drawing.Color.White;
            this.InjectorBtn.Location = new System.Drawing.Point(8, 12);
            this.InjectorBtn.Name = "InjectorBtn";
            this.InjectorBtn.Size = new System.Drawing.Size(163, 23);
            this.InjectorBtn.TabIndex = 0;
            this.InjectorBtn.Text = "Start";
            this.InjectorBtn.UseVisualStyleBackColor = false;
            this.InjectorBtn.Click += new System.EventHandler(this.InjectorBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InjectorStatus_textBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Injector Status";
            // 
            // InjectorStatus_textBox
            // 
            this.InjectorStatus_textBox.BackColor = System.Drawing.Color.Red;
            this.InjectorStatus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InjectorStatus_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InjectorStatus_textBox.ForeColor = System.Drawing.Color.White;
            this.InjectorStatus_textBox.Location = new System.Drawing.Point(10, 19);
            this.InjectorStatus_textBox.Name = "InjectorStatus_textBox";
            this.InjectorStatus_textBox.ReadOnly = true;
            this.InjectorStatus_textBox.Size = new System.Drawing.Size(151, 22);
            this.InjectorStatus_textBox.TabIndex = 0;
            this.InjectorStatus_textBox.Text = "Stopped";
            this.InjectorStatus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LeagueGameStatus_textBox);
            this.groupBox2.Location = new System.Drawing.Point(5, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "League Game Status";
            // 
            // LeagueGameStatus_textBox
            // 
            this.LeagueGameStatus_textBox.BackColor = System.Drawing.Color.Red;
            this.LeagueGameStatus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeagueGameStatus_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LeagueGameStatus_textBox.ForeColor = System.Drawing.Color.White;
            this.LeagueGameStatus_textBox.Location = new System.Drawing.Point(10, 19);
            this.LeagueGameStatus_textBox.Name = "LeagueGameStatus_textBox";
            this.LeagueGameStatus_textBox.ReadOnly = true;
            this.LeagueGameStatus_textBox.Size = new System.Drawing.Size(151, 22);
            this.LeagueGameStatus_textBox.TabIndex = 0;
            this.LeagueGameStatus_textBox.Text = "Not Found";
            this.LeagueGameStatus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InjectStatus_textBox);
            this.groupBox3.Location = new System.Drawing.Point(5, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "R3nzSkin Status";
            // 
            // InjectStatus_textBox
            // 
            this.InjectStatus_textBox.BackColor = System.Drawing.Color.Red;
            this.InjectStatus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InjectStatus_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InjectStatus_textBox.ForeColor = System.Drawing.Color.White;
            this.InjectStatus_textBox.Location = new System.Drawing.Point(10, 19);
            this.InjectStatus_textBox.Name = "InjectStatus_textBox";
            this.InjectStatus_textBox.ReadOnly = true;
            this.InjectStatus_textBox.Size = new System.Drawing.Size(151, 22);
            this.InjectStatus_textBox.TabIndex = 0;
            this.InjectStatus_textBox.Text = "Not Injected";
            this.InjectStatus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R3nzSkin_Label
            // 
            this.R3nzSkin_Label.AutoSize = true;
            this.R3nzSkin_Label.LinkColor = System.Drawing.Color.Black;
            this.R3nzSkin_Label.Location = new System.Drawing.Point(6, 206);
            this.R3nzSkin_Label.Name = "R3nzSkin_Label";
            this.R3nzSkin_Label.Size = new System.Drawing.Size(166, 13);
            this.R3nzSkin_Label.TabIndex = 1;
            this.R3nzSkin_Label.TabStop = true;
            this.R3nzSkin_Label.Text = "© 2021-2023 R3nzTheCodeGOD";
            this.R3nzSkin_Label.VisitedLinkColor = System.Drawing.Color.Red;
            this.R3nzSkin_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.R3nzSkin_Label_LinkClicked);
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 227);
            this.Controls.Add(this.R3nzSkin_Label);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InjectorBtn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Injector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InjectorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InjectorStatus_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LeagueGameStatus_textBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox InjectStatus_textBox;
        private System.Windows.Forms.LinkLabel R3nzSkin_Label;
    }
}