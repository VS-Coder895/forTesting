using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using Guna.UI2.WinForms;

namespace CarRental.UI
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
            conFilter.LoadType(typeof(Payment));
            conFilter.Filtered += (s, _e) =>
            {
                _RefreshData(s as DataTable);
            };
        }
        private void _RefreshData(DataTable Payments)
        {
            dataGridViewPayments.DataSource = Payments;
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            _RefreshData(Payment.GetAll());
        }
        private void DetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentDetails frmUpdate = new frmPaymentDetails((int)
                dataGridViewPayments.Rows[dataGridViewPayments.CurrentCell.RowIndex].Cells[0].Value);
            frmUpdate.ShowDialog();
        }
        private void UpdateStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePayment frmUpdate = new frmUpdatePayment((int)
                dataGridViewPayments.Rows[dataGridViewPayments.CurrentCell.RowIndex].Cells[0].Value);
            frmUpdate.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);

            //if (ActiveUser.user?.userRole.ToLower() == "admin")
            //{
            //    grpBoxUpdatePayment.Visible = true;
            //}
            //else if(true)
            //{
            //    MessageBox.Show("Access Denied.");
            //}
        }
        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment.DeleteByPaymentID((int)dataGridViewPayments.Rows[dataGridViewPayments.CurrentCell.RowIndex].Cells[0].Value);
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Guna2GroupBox con = (sender as Guna2PictureBox).Parent as Guna2GroupBox;
            con.Visible = false;
        }
        private void dataGridViewPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
