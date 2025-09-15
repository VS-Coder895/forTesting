using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;

namespace CarRental.UI
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
            conFilter.LoadType(typeof(Vehicle));
            conFilter.Filtered += (s, _e) =>
            {
                _RefreshCars(s as DataTable);
            };
        }
        void _RefreshCars(DataTable Vehicles)
        {
            dgvShowCars.DataSource = Vehicles;
        }
        private void frmCars_Load(object sender, EventArgs e)
        {
            _RefreshCars(Vehicle.GetAll());
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarDeatils frm = new frmCarDeatils((int)dgvShowCars.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            // pass the -1 id to make mode's status => AddNew
            frmAddEditCar frm = new frmAddEditCar(-1);
            frm.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pass the car's id to make mode's status is => Update
            frmAddEditCar car = new frmAddEditCar((int)dgvShowCars.CurrentRow.Cells[0].Value);
            car.ShowDialog();
            conFilter.txtBoxSearch_TextChanged(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShowCars.CurrentRow == null)
            {
                MessageBox.Show("Please select a car to delete.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(dgvShowCars.CurrentRow.Cells[0].Value?.ToString(), out int carId))
            {
                MessageBox.Show("Invalid car ID.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show($"Are you sure you want to delete this car (ID: {carId})?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {



                if (Vehicle.DeleteByID(carId))
                {
                    MessageBox.Show("Car deleted successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conFilter.txtBoxSearch_TextChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to delete the car. It may already be deleted or in use.",
                                  "Deletion Failed",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the car: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvShowCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void conFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
