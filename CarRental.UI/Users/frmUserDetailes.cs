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
    public partial class frmUserDetailes : Form
    {
        int _UserID = -1;
        User _User;

        public frmUserDetailes(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        void _LoadDataByID(int UserID)
        {
            try
            {
                _User = User.FindByUserID(UserID);

                if (_User == null)
                {
                    MessageBox.Show("No user found with ID = " + UserID, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblID.Text = UserID.ToString();
                lblUserName.Text = _User.userName;
                lblPassword.Text = _User.userPassword;
                lblRole.Text = _User.userRole;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUserDetailes_Load(object sender, EventArgs e)
        {
            _LoadDataByID(_UserID);
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(_UserID);
            frm.ShowDialog();
            
        }
    }
}