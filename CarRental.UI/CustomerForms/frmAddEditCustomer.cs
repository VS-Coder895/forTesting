using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmAddEditCustomer : Form
    {
        enum enMode { Update = 0, AddNew = 1 };
        enMode _Mode;

        Customer _Cus;
        int _CustomerID = -1;

        public frmAddEditCustomer(int ID)
        {
            InitializeComponent();
            _CustomerID = ID;

            if (_CustomerID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Customer";
                _Cus = new Customer();
                return;
            }

            _Cus = Customer.Find(_CustomerID);

            if (_Cus is null)
            {
                MessageBox.Show("This form will be closed because No Customer with ID = " + _CustomerID);
                this.Close();
                return;
            }
            else
            {
                lblMode.Text = "Update Customer";

                lblID.Text = _CustomerID.ToString();
                txtAddress.Text = _Cus.Address.ToString();
                txtDLN.Text = _Cus.DLN.ToString();
                txtEmail.Text = _Cus.Email.ToString();
                txtPhone.Text = _Cus.PhoneNumber.ToString();
                txtName.Text = _Cus.Name.ToString();
            }
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                _Cus.Address=txtAddress.Text;
                _Cus.Email=txtEmail.Text;
                _Cus.DLN=txtDLN.Text;
                _Cus.Name=txtName.Text;
                _Cus.PhoneNumber=txtPhone.Text;

                if (_Cus.Save())
                {
                    MessageBox.Show("Customer saved successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the Customer.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Mode = enMode.Update;
                lblMode.Text = "Edit Car ID = " + _Cus.CustomerID;
                lblID.Text = _Cus.CustomerID.ToString();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, string.Empty);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtEmail, "Email is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, string.Empty);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtAddress, "Address is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, string.Empty);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtPhone, "Phone is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, string.Empty);
            }
        }

        private void txtDLN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDLN.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtDLN, "DLN is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDLN, string.Empty);
            }
        }
    }
}
