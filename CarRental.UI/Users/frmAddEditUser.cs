using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.UI.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { Update = 0, AddNew = 1 };
        enMode _Mode;
        int _UserID = -1;
        User _User;

        public frmAddEditUser(int ID)
        {
            InitializeComponent();
            _UserID = ID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User";
                _User = new User();
                return;
            }

            _User = User.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();
                return;
            }
            lblID.Text = _UserID.ToString();
            txtUserName.Text = _User.userName.ToString();
            txtPassword.Text = _User.userPassword.ToString();
            txtRole.Text = _User.userRole.ToString();

            lblMode.Text = "Update User";
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _User.userName = txtUserName.Text;
                _User.userPassword = txtPassword.Text;
                _User.userRole = txtRole.Text;

                if (_User.Save())
                {
                    MessageBox.Show("User saved successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the User.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Mode = enMode.Update;
                lblMode.Text = "Edit User ID = " + _User.userId;
                lblID.Text = _User.userId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "Username is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void txtRole_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                e.Cancel = true;
                txtRole.Focus();
                errorProvider1.SetError(txtRole, "Role is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRole, string.Empty);
            }
        }
    }
}