using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmAddEditCarRental : Form
    {
        private enum enMode { Update = 0, AddNew = -1 };

        private enMode _Mode = enMode.AddNew;

        int _RentalId = -1;

        Rental _vehicleRental;
        public frmAddEditCarRental(int RentalId)
        {
            InitializeComponent();

            _RentalId = RentalId;
            if (RentalId == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
                _Mode = enMode.Update;
        }
        private void _SetInsuranceRental()
        {
            cbInsurance.DataSource = Insurances.GetAll();
            cbInsurance.DisplayMember = "Name";
            cbInsurance.ValueMember = "InsuranceID";
        }
        private void _SetVehicleRental()
        {

            cbVehicleRental.DataSource = Vehicle.GetAll();
            cbVehicleRental.DisplayMember = "Name";
            cbVehicleRental.ValueMember = "VehicleID";
        }
        private void _SetCustomerRental()
        {
            cbCustomer.DataSource = Customer.GetAll();
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";
        }
        private void _LoadData()
        {
            _SetVehicleRental();
            _SetCustomerRental();
            _SetInsuranceRental();

            if (_Mode == enMode.AddNew)
            {
                lblRentilTitle.Text = "Add New Rental ";
                _vehicleRental = new Rental();
                return;
            }

            _vehicleRental = Rental.FindByRentalID(_RentalId);

            if (_vehicleRental == null)
            {
                MessageBox.Show("This form will be closed because No Rental with ID = " + _RentalId);
                this.Close();

                return;
            }

            lblRentalId.Text = _vehicleRental.RentalID.ToString();
            cbCustomer.SelectedValue = _vehicleRental.CustomerID;

            cbVehicleRental.SelectedValue = _vehicleRental.VehicleID;
            cbInsurance.SelectedValue = _vehicleRental.InsuranceID;
            dtRentalStartDate.Value = _vehicleRental.StartDate;
            dtRentalEndDate.Value = _vehicleRental.EndDate;
            txtCheckNotes.Text = _vehicleRental.InitialCheckNotes;
            txtPickUpLocation.Text = _vehicleRental.PickupLocation;
            txtDropOfLocation.Text = _vehicleRental.DropOffLocation;
            txtPricePerDay.Text = _vehicleRental.DailyRate.ToString();
            txtPricePerDays.Text = _vehicleRental.RentalDays.ToString();
            txtTotalAmount.Text = _vehicleRental.TotalDue.ToString();

            lblRentilTitle.Text = "Update Rental";
        }
        private void frmAddEditCarRental_Load(object sender, EventArgs e)
        {
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDown;
            cbVehicleRental.DropDownStyle = ComboBoxStyle.DropDown;

            _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddInitialPayment payment = new frmAddInitialPayment(_RentalId);
            payment.ShowDialog();

            try
            {
                _vehicleRental.CustomerID = (int)cbCustomer.SelectedValue;
                _vehicleRental.VehicleID = (int)cbVehicleRental.SelectedValue;
                _vehicleRental.InsuranceID = Convert.ToInt32(cbInsurance.SelectedValue);
                _vehicleRental.StartDate = dtRentalStartDate.Value;
                _vehicleRental.EndDate = dtRentalEndDate.Value;
                _vehicleRental.UserID = ActiveUser.user.userId;
                _vehicleRental.InitialCheckNotes = txtCheckNotes.Text;
                _vehicleRental.PickupLocation = txtPickUpLocation.Text;
                _vehicleRental.DropOffLocation = txtDropOfLocation.Text;
                _vehicleRental.DailyRate = decimal.Parse(txtPricePerDay.Text);
                _vehicleRental.TotalDue = decimal.Parse(txtTotalAmount.Text);

                if (_vehicleRental.Save())
                {
                    MessageBox.Show("rental save successfully with rental Id", "succeseed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to save vehicle rental", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Mode = enMode.Update;
                lblRentilTitle.Text = "Edit Rental Id" + _vehicleRental.RentalID;
                lblRentalId.Text = _vehicleRental.RentalID.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid numeric values in the appropriate fields.",
                              "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occur: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _CalculateTotalDue()
        {
            if (int.TryParse(txtPricePerDays.Text, out int rentalDays) &&
                decimal.TryParse(txtPricePerDay.Text, out decimal pricePerDay))
            {
                decimal total = rentalDays * pricePerDay;
                txtTotalAmount.Text = total.ToString("0.00");
            }
            else
            {
                txtTotalAmount.Text = "0.00";
            }
        }
        private void _CalculateRentalDays()
        {
            if (dtRentalEndDate.Value >= dtRentalStartDate.Value)
            {
                int days = (dtRentalEndDate.Value - dtRentalStartDate.Value).Days;
                txtPricePerDays.Text = days.ToString();
            }
            else
            {
                txtPricePerDays.Text = "0";
            }
            _CalculateTotalDue();
        }
        private void dtRentalStartDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateRentalDays();
        }
        private void dtRentalEndDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateRentalDays();
        }
        private void txtPricePerDay_TextChanged(object sender, EventArgs e)
        {
            _CalculateTotalDue();
        }
        private void _CheckValidation(Control control, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true;
                control.Focus();
                errorProvider1.SetError(control, "is required");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(control, string.Empty);
            }
        }
        private void AllValidating(object sender, CancelEventArgs e)
        {
            _CheckValidation(sender as Control, e);
        }
    }
}
