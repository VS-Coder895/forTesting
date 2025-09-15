using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmAddEditCar : Form
    {
        Vehicle _Vehicle;
        int _CarID = -1;

        enum enMode { Update = 0, AddNew = 1 };
        enMode _Mode;

        public frmAddEditCar(int carID)
        {
            InitializeComponent();

            _CarID = carID;

            if (carID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
        private void frmAddEditCar_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        void SetEngineTypes()
        {
            cbEngineType.DataSource = EngineType.GetAll();
            cbEngineType.DisplayMember = "Name";
            cbEngineType.ValueMember = "EngineTypeID";
        }
        void SetFuelTypes()
        {
            cbFuelType.DataSource = FuelType.GetAll();
            cbFuelType.DisplayMember = "Name";
            cbFuelType.ValueMember = "FuelTypeID";
        }
        void SetManufacturers()
        {
            cbManufacturer.DataSource = Manufacturer.GetAll();
            cbManufacturer.DisplayMember = "Name";
            cbManufacturer.ValueMember = "ManufacturerID";
        }
        void SetVehicleTypes()
        {
            cbVehicleType.DataSource = VehicleType.GetAll();
            cbVehicleType.DisplayMember = "Name";
            cbVehicleType.ValueMember = "VehicleTypeID";
        }
        void _LoadData()
        {

            SetVehicleTypes();
            SetManufacturers();
            SetFuelTypes();
            SetEngineTypes();

            if (_Mode == enMode.AddNew)
            {
                lbMode.Text = "Add New Car";
                _Vehicle = new Vehicle();
                return;
            }

            _Vehicle = Vehicle.FindByVehicleID(_CarID);

            if (_Vehicle == null)
            {
                MessageBox.Show("This form will be closed because No Car with ID = " + _CarID);
                this.Close();

                return;
            }
            else
            {
                lbMode.Text = "Update Car";

                lblCarID.Text = _Vehicle.VehicleID.ToString();
                txtName.Text = _Vehicle.Name;
                txtModel.Text = _Vehicle.Model.ToString();

                cbColor.SelectedItem = _Vehicle.Color;
                txtTransmissionType.Text = _Vehicle.TransmissionType.ToString();
                cbEngineType.SelectedValue = _Vehicle.EngineTypeID;
                cbFuelType.SelectedValue = _Vehicle.FuelTypeID;
                cbManufacturer.SelectedValue = _Vehicle.ManufacturerID;
                cbVehicleType.SelectedValue = _Vehicle.VehicleTypeID;
                cbAvalibality.SelectedIndex = _Vehicle.IsVehicleAvailable ? 0 : 1;
                txtFuelEfficiency.Text = _Vehicle.FuelEfficiency.ToString();


                txtLicencePlate.Text = _Vehicle.LPN;
                txtRentalPrice.Text = _Vehicle.DailyRentalPrice.ToString();
                txtMileage.Text = _Vehicle.Mileage.ToString();
                txtSeating.Text = _Vehicle.SeatingCapacity.ToString();
                dtpLastService.Value = _Vehicle.LastServicesDate;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                _Vehicle.Name = txtName.Text;
                _Vehicle.Model = int.Parse(txtModel.Text);
                _Vehicle.ManufacturerID = (int)cbManufacturer.SelectedValue;
                _Vehicle.LPN = txtLicencePlate.Text;
                _Vehicle.Color = cbColor.SelectedItem.ToString();
                _Vehicle.FuelTypeID = (int)cbFuelType.SelectedValue;
                _Vehicle.DailyRentalPrice = decimal.Parse(txtRentalPrice.Text);
                _Vehicle.EngineTypeID = (int)cbEngineType.SelectedValue;
                _Vehicle.FuelEfficiency = decimal.Parse(txtFuelEfficiency.Text);
                _Vehicle.TransmissionType = txtTransmissionType.Text;
                _Vehicle.SeatingCapacity = int.Parse(txtSeating.Text);
                _Vehicle.VehicleTypeID = (int)cbVehicleType.SelectedValue;
                _Vehicle.IsVehicleAvailable = cbAvalibality.SelectedIndex == 0 ? false : true;
                _Vehicle.LastServicesDate = dtpLastService.Value;
                _Vehicle.Mileage = decimal.Parse(txtMileage.Text);

                if (_Vehicle.Save())
                {
                    MessageBox.Show("Vehicle saved successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the vehicle.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Mode = enMode.Update;
                lblMode.Text = "Edit Car ID = " + _Vehicle.VehicleID;
                lblCarID.Text = _Vehicle.VehicleID.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid numeric values in the appropriate fields.",
                              "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("A vehicle with these details already exists. Please check license plate and other unique fields.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtName_Validating(object sender, CancelEventArgs e)
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
        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtModel, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtModel, string.Empty);
            }
        }
        private void txtLicencePlate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicencePlate.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtLicencePlate, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLicencePlate, string.Empty);
            }
        }
        private void txtRentalPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRentalPrice.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtRentalPrice, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRentalPrice, string.Empty);
            }
        }
        private void txtFuelEfficiency_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFuelEfficiency.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtFuelEfficiency, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFuelEfficiency, string.Empty);
            }
        }
        private void Transmission_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTransmissionType.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtTransmissionType, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTransmissionType, string.Empty);
            }
        }
        private void txtSeating_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSeating.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtSeating, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSeating, string.Empty);
            }
        }
        private void cbAvalibality_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAvalibality.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(cbAvalibality, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbAvalibality, string.Empty);
            }
        }
        private void txtMileage_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMileage.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtMileage, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMileage, string.Empty);
            }
        }
        private void cbManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbManufacturer.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(cbManufacturer, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbManufacturer, string.Empty);
            }
        }
        private void cbColor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbColor.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(cbColor, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbColor, string.Empty);
            }
        }
        private void cbFuelType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbFuelType.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(cbFuelType, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbFuelType, string.Empty);
            }
        }
        private void cbEngineType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEngineType.Text))

            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(cbEngineType, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbEngineType, string.Empty);
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
