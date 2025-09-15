using CarRental.UI.Users;
using System;
using System.Windows.Forms;
using UI;

namespace CarRental.UI
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbCurrentUserName.Text = ActiveUser.user.userName;
            lbCurrentUserRole.Text = ActiveUser.user.userRole;
        }

        private void btnOpenfrmUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenfrmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenfrmCar_Click(object sender, EventArgs e)
        {
            frmCars frm = new frmCars();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenfrmRental_Click(object sender, EventArgs e)
        {
            frmVehicleRental frm = new frmVehicleRental();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenfrmPayment_Click(object sender, EventArgs e)
        {
            frmRentalPayment frm = new frmRentalPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenfrmReturns_Click(object sender, EventArgs e)
        {
            frmVehicleRental frm = new frmVehicleRental();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm frm = this.Tag as loginForm;
            frm.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }
    }
}
