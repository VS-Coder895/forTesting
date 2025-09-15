using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conVehicleInfo : UserControl
    {
        public conVehicleInfo()
        {
            InitializeComponent();
        }
        public void SetVehicleData(int vehicleID)
        {
            Vehicle vehicle = Vehicle.FindByVehicleID(vehicleID);
            lblEngineType.Text = vehicle.GetEngineType().Name;
            lblFuelType.Text = vehicle.GetFuelType().Name;
            lblVehicleType.Text = vehicle.GetVehicleType().Name;
            lblManufacturer.Text = vehicle.GetManufacturer().Name;
            lblILastServDate.Text = vehicle.LastServicesDate.ToString();
            lblCarID.Text = vehicle.VehicleID.ToString();
            lblFuleEfficincy.Text = vehicle.FuelEfficiency.ToString();
            lblLicencePlate.Text = vehicle.LPN;
            lblCarName.Text = vehicle.Name;
            lblColor.Text = vehicle.Color;
            lblMileage.Text = vehicle.Mileage.ToString();
            lblModel.Text = vehicle.Model.ToString();
            lblRentalPrice.Text = vehicle.DailyRentalPrice.ToString();
            lblSeating.Text = vehicle.SeatingCapacity.ToString();
            lblStatus.Text = vehicle.IsVehicleAvailable == false ? "Not Availible" : "Available";
            lblTransmission.Text = vehicle.TransmissionType.ToString();
        }
        public bool isVehicleAvailableInRange(DateTime start, DateTime end)
        {
            if (isVehicleFound())
            {
                Vehicle vehicle = Vehicle.FindByVehicleID(GetVehicleID());
                return vehicle.IsAvailableVehicleInRange(start, end);
            }
            return false;
        }
        public bool isVehicleFound()
        {
            return !string.IsNullOrEmpty(lblCarID.Text);
        }
        public int GetVehicleID()
        {
            return Convert.ToInt32(lblCarID.Text);
        }
        public bool isVehicleAvailable()
        {
            return lblStatus.Text == "Available";
        }
        public void ChangeVehicleAvailablility(bool isAvailable)
        {
            lblStatus.Text = isAvailable? "Available" : "Not Availible";
        }

    }
}
