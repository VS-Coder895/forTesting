using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conAddRental : UserControl
    {
        public conAddRental()
        {
            InitializeComponent();

            conFilter.clsType = typeof(Customer);
            conFilterVehicle.clsType = typeof(Vehicle);
            conFilter.Filtered += (s, e) =>
            {
                conCustomerInfo.SetCustomerData((int)s);
            };
            conFilterVehicle.Filtered += (s, e) =>
            {
                conVehicleInfo.SetVehicleData((int)s);
                conVehicleInfo.ChangeVehicleAvailablility(conVehicleInfo.
                    isVehicleAvailableInRange(conAddEditRental.dtRentalStartDate.Value,
                    conAddEditRental.dtRentalEndDate.Value));
            };
            conAddEditRental.numTotalDueAmount.ValueChanged += conAddEditInitialPayment.numTotalDue_ValueChanged;
            conAddEditRental.dtRentalStartDate.ValueChanged += (s, e) =>
            {
                conVehicleInfo.ChangeVehicleAvailablility(conVehicleInfo.
                    isVehicleAvailableInRange(conAddEditRental.dtRentalStartDate.Value,
                    conAddEditRental.dtRentalEndDate.Value));
            };
            conAddEditRental.dtRentalEndDate.ValueChanged += (s, e) =>
            {
                conVehicleInfo.ChangeVehicleAvailablility(conVehicleInfo.
                    isVehicleAvailableInRange(conAddEditRental.dtRentalStartDate.Value,
                    conAddEditRental.dtRentalEndDate.Value));
            };
        }
        public bool LoadRental(Rental rental)
        {
            if (rental == null) { return false; }
            conCustomerInfo.SetCustomerData(rental.CustomerID);
            conVehicleInfo.SetVehicleData(rental.VehicleID);
            conAddEditRental.LoadRental(rental);
            conAddEditInitialPayment.LoadPayment(rental.GetPayment());
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!conCustomerInfo.isCustomerFound())
            {
                MessageBox.Show("The Customer doesn`t assign.");
                return;
            }
            conAddEditRental.VehicleRental.CustomerID = conCustomerInfo.GetCustomerID();

            if (!conVehicleInfo.isVehicleFound())
            {
                MessageBox.Show("The vehicle doesn`t assign.");
                return;
            }
            if (!conVehicleInfo.isVehicleAvailable())
            {
                MessageBox.Show("this car is not available.");
                return;
            }
            conAddEditRental.VehicleRental.VehicleID = conVehicleInfo.GetVehicleID();
            if (!conAddEditRental.Save())
            {
                MessageBox.Show("There are an error in Rental saving.");
                return;
            }
            conAddEditInitialPayment.Payment.RentalID = conAddEditRental.VehicleRental.RentalID;
            if (!conAddEditInitialPayment.Save())
            {
                MessageBox.Show("There are an error in Payment saving.");
                return;
            }
            MessageBox.Show("Vehicle booked successfully from " + conAddEditRental.VehicleRental.StartDate.ToShortDateString() + " to " +
                conAddEditRental.VehicleRental.EndDate.ToShortDateString() + ".", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (conAddEditRental.VehicleRental.RentalID != -1)
            {
                Vehicle vehicle = conAddEditRental.VehicleRental.GetVehicle(); ;
                vehicle.IsVehicleAvailable = true;
                vehicle.Save();
            }
            (this.Parent as Form).Close();
        }
    }
}
