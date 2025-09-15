using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmCarRentalDeatils : Form
    {

        private int _RentalId=-1;
        private Rental _VehicleRental;
        public frmCarRentalDeatils(int rentId)
        {
            InitializeComponent();
            _RentalId = rentId;
        }

        private void _LoadData()
        {
            try
            {
                _VehicleRental = Rental.FindByRentalID(_RentalId);

                lblCustomerRental.Text = _VehicleRental.GetCustomer().Name;
                lblRentalId.Text = _VehicleRental.RentalID.ToString();

                lblVehicleRental.Text = _VehicleRental.GetVehicle().Name;
                //lblInsuranceRental.Text = _VehicleRental.GetInsurance().Name;

                lblStartDate.Text = _VehicleRental.StartDate.ToString();
                lblEndDate.Text = _VehicleRental.EndDate.ToString();

                lblCheckNotes.Text = _VehicleRental.InitialCheckNotes;
                lblPickUpLocation.Text = _VehicleRental.PickupLocation;
                lblDropOfLocation.Text = _VehicleRental.DropOffLocation;
                lblPricePerDay.Text = _VehicleRental.DailyRate.ToString();
                lblPricePerDays.Text = _VehicleRental.RentalDays.ToString();
                lblTotalAmount.Text = _VehicleRental.TotalDue.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"An unexpected error occur: {ex.Message} ");
                this.Close();
            }

        }

        private void guna2HtmlLabel20_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCarRentalDeatils_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
