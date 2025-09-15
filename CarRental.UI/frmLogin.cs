using System;
using System.Windows.Forms;
using BusinessLayer;
using CarRental.UI;

namespace UI
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string password = txtBoxPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Failed to login!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = User.FindByUserNameAndPassword(userName, password);

                if (user is null)
                {
                    MessageBox.Show("Failed to login!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ActiveUser.user = user;
                    frmDashboard dashboard = new frmDashboard();

                    dashboard.Tag = this;
                    dashboard.Show();
                    this.Hide();

                    txtBoxUserName.Clear();
                    txtBoxPassword.Clear();
                    txtBoxUserName.Focus();
                }
            }
        }

        private void btnfrmAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Tag = this;
            frmAbout.Show();
        }
    }
}
