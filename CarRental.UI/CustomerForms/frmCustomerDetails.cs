using BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmCustomerDetails : Form
    {
        int _CustomerId = -1;
        Customer cus;
        public frmCustomerDetails(int customerId)
        {
            InitializeComponent();
            _CustomerId = customerId;
        }

        void _LoadDataByID()
        {
            try
            {
                cus = Customer.Find(_CustomerId);

                lblID.Text = cus.CustomerID.ToString();
                lblName.Text = cus.Name;
                lblEmail.Text = cus.Email;
                lblPhone.Text = cus.PhoneNumber;
                lblDLN.Text = cus.DLN;
                lblAddress.Text = cus.Address;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            _LoadDataByID();
        }

        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer(_CustomerId);
            frm.ShowDialog();
        }
    }
}
