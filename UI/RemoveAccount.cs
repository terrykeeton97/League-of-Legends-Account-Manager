using Acccount_Manager.Classes.Data;
using Acccount_Manager.Classes.Utility;
using System.Windows.Forms;

namespace Acccount_Manager.UI
{
    public partial class RemoveAccount : Form
    {
        public RemoveAccount()
        {
            InitializeComponent();
            Text = Utils.GenerateString();
            CredentialsService.LoadCredentials();
            foreach (var credentials in CredentialsService.Credentials)
                accountListBox.Items.Add(credentials.Username);          
        }

        private void RemoveAccountBtn_Click(object sender, System.EventArgs e)
        {
            if (accountListBox.SelectedItem is string selectedAccount)
            {
                CredentialsService.RemoveCredentials(selectedAccount);
                accountListBox.Items.Clear();
                CredentialsService.LoadCredentials();
                foreach (var credentials in CredentialsService.Credentials)
                    accountListBox.Items.Add(credentials.Username);
            }
        }
    }
}
