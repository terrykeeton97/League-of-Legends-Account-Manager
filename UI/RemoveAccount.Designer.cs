namespace Acccount_Manager.UI
{
    partial class RemoveAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAccount));
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.removeAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountListBox
            // 
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.Location = new System.Drawing.Point(5, 3);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(169, 160);
            this.accountListBox.TabIndex = 0;
            // 
            // removeAccountBtn
            // 
            this.removeAccountBtn.Location = new System.Drawing.Point(5, 169);
            this.removeAccountBtn.Name = "removeAccountBtn";
            this.removeAccountBtn.Size = new System.Drawing.Size(169, 23);
            this.removeAccountBtn.TabIndex = 1;
            this.removeAccountBtn.Text = "Remove Account";
            this.removeAccountBtn.UseVisualStyleBackColor = true;
            this.removeAccountBtn.Click += new System.EventHandler(this.RemoveAccountBtn_Click);
            // 
            // RemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 197);
            this.Controls.Add(this.removeAccountBtn);
            this.Controls.Add(this.accountListBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.Button removeAccountBtn;
    }
}