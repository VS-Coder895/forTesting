using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmCustomer : Form
    {
         public frmCustomer()
        {
            InitializeComponent();

            conFilter.LoadType(typeof(Customer));
            conFilter.Filtered += (s, _e) =>
            {
                _RefreshCustomersList(s as DataTable);
            };
        }
        private void _RefreshCustomersList(DataTable customer)
        {
            dgvShowCustomers.DataSource = customer;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            _RefreshCustomersList(Customer.GetAll());
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer(-1);
            frm.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvShowCustomers.CurrentRow == null)
            {
                return;
            }
            else
            {
                int customerID = (int)((DataRowView)dgvShowCustomers.CurrentRow.DataBoundItem)["CustomerID"];
                frmCustomerDetails frm = new frmCustomerDetails(customerID);
                frm.ShowDialog();
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvShowCustomers.CurrentRow == null)
            {
                return;
            }
            else
            {
                int customerID = (int)((DataRowView)dgvShowCustomers.CurrentRow.DataBoundItem)["CustomerID"];
                frmAddEditCustomer frm = new frmAddEditCustomer(customerID);
                frm.ShowDialog();
                conFilter.txtBoxSearch_TextChanged(null, null);
            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgvShowCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a Customer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int customerID = (int)((DataRowView)dgvShowCustomers.CurrentRow.DataBoundItem)["CustomerID"];

            bool confirmDeletion = MessageBox.Show($"Are you sure you want to delete this Customer (ID: {customerID})?"
                , "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (confirmDeletion == true)
            {
                if (Customer.Delete(customerID) == true)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        conFilter.txtBoxSearch_TextChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Failed delete customer.", "Deletion Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
