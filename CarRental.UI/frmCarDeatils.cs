using System;
using System.Windows.Forms;
using BusinessLayer;


namespace CarRental.UI
{
    public partial class frmCarDeatils : Form
    {
        int _CarID = -1;
        Vehicle _Vehicle;
        public frmCarDeatils(int carID)
        {
            InitializeComponent();
            _CarID = carID;
        }
        void _LoadDataByID(int CarID)
        {
            try
            {
                _Vehicle = Vehicle.FindByVehicleID(CarID);

                lblEngineType.Text = _Vehicle.GetEngineType().Name;
                lblFuelType.Text = _Vehicle.GetFuelType().Name;
                lblVehicleType.Text = _Vehicle.GetVehicleType().Name;
                lblManufacturer.Text = _Vehicle.GetManufacturer().Name;
                lblILastServDate.Text = _Vehicle.LastServicesDate.ToString();
                lblCarID.Text = CarID.ToString();
                lblFuleEfficincy.Text = _Vehicle.FuelEfficiency.ToString();
                lblLicencePlate.Text = _Vehicle.LPN;
                lblCarName.Text = _Vehicle.Name;
                lblColor.Text = _Vehicle.Color;
                lblMileage.Text = _Vehicle.Mileage.ToString();
                lblModel.Text = _Vehicle.Model.ToString();
                lblRentalPrice.Text = _Vehicle.DailyRentalPrice.ToString();
                lblSeating.Text = _Vehicle.SeatingCapacity.ToString();
                lblStatus.Text = _Vehicle.IsVehicleAvailable == false ? "Not Availible" : "Available";
                lblTransmission.Text = _Vehicle.TransmissionType.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCarDeatils_Load(object sender, EventArgs e)
        {
            _LoadDataByID(_CarID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
  

}
