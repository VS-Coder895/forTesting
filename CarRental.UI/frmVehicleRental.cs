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

namespace CarRental.UI
{
    public partial class frmVehicleRental : Form
    {
        public frmVehicleRental()
        {
            InitializeComponent();
            conFilter.LoadType(typeof(Rental));
            conFilter.Filtered += (s, e) => _RefreshCarsRental(s as DataTable);
        }
        private void _RefreshCarsRental(DataTable rental)
        {
            dgvShowCarRental.DataSource = rental;
        }
        private void dgvShowCarRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmVehicleRental_Load(object sender, EventArgs e)
        {
            _RefreshCarsRental(Rental.GetAll());
        }
        private void btnAddNewCarRental_Click(object sender, EventArgs e)
        {
            conAddRental con = new conAddRental();
            Form frm = new Form();
            frm.Controls.Add(con);
            frm.AutoSize = true;
            frm.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowCarRental.CurrentRow == null)
                return;
            frmCarRentalDeatils frm = new frmCarRentalDeatils((int)dgvShowCarRental.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShowCarRental.CurrentRow == null)
                return;
            conAddRental con = new conAddRental();
            con.LoadRental(Rental.FindByRentalID((int)dgvShowCarRental.CurrentRow.Cells[0].Value));
            Form frm = new Form();
            frm.Controls.Add(con);
            frm.AutoSize = true;
            frm.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowCarRental.CurrentRow == null)
                return;
            int DeleteID = (int)dgvShowCarRental.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete this id rental: {DeleteID} ", "delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (Rental.Delete(DeleteID))
                    {
                        conFilter.txtBoxSearch_TextChanged(null, null);
                        MessageBox.Show("Deleted Successfully With ID: " + DeleteID, " Delete");
                    }
                    else
                    {

                        MessageBox.Show($"Failed to delete with Id: {DeleteID}", "delete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occur {ex.Message} ");
                }
            }
            else
            {
                MessageBox.Show("Failed to delete ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
