using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conCustomerInfo : UserControl
    {
        public conCustomerInfo()
        {
            InitializeComponent();
        }
        public void SetCustomerData(int customerID)
        {
            Customer customer = Customer.Find(customerID);
            if(customer == null) { return; }
            lblID.Text = customer.CustomerID.ToString();
            lblDLN.Text = customer.DLN;
            lblEmail.Text = customer.Email;
            lblPhone.Text = customer.PhoneNumber;
            lblName.Text = customer.Name;
        }
        public bool isCustomerFound()
        {
            return !string.IsNullOrEmpty(lblID.Text);
        }
        public int GetCustomerID()
        {
            return Convert.ToInt32(lblID.Text);
        }

        private void lblEditCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
