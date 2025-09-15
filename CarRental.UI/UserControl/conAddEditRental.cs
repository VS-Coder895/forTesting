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
    public partial class conAddEditRental : UserControl
    {
        private enum enMode { Update = 0, AddNew = -1 };
        private enMode _Mode = enMode.AddNew;
        public Rental VehicleRental;
        public conAddEditRental()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            VehicleRental = new Rental();
        }
        private void _LoadDataToUI()
        {
            txtBoxlRentalId.Text = VehicleRental.RentalID.ToString();
            cbInsurance.SelectedValue = VehicleRental.InsuranceID;
            dtRentalStartDate.Value = VehicleRental.StartDate;
            dtRentalEndDate.Value = VehicleRental.EndDate;
            txtBoxCheckNotes.Text = VehicleRental.InitialCheckNotes;
            txtBoxPickUpLocation.Text = VehicleRental.PickupLocation;
            txtBoxDropOfLocation.Text = VehicleRental.DropOffLocation;
            numInitialRentalDays.Value = VehicleRental.RentalDays;
            numPricePerDay.Value = VehicleRental.DailyRate;
            numTotalDueAmount.Value = VehicleRental.TotalDue;
        }
        public void LoadRental(Rental rental)
        {
            VehicleRental = rental;
            _Mode = enMode.Update;
            _LoadDataToUI();
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            VehicleRental.InsuranceID = Convert.ToInt32(cbInsurance.SelectedValue);
            VehicleRental.StartDate = dtRentalStartDate.Value;
            VehicleRental.EndDate = dtRentalEndDate.Value;
            VehicleRental.UserID = ActiveUser.user is null ? 1 : ActiveUser.user.userId;
            VehicleRental.InitialCheckNotes = txtBoxCheckNotes.Text;
            VehicleRental.PickupLocation = txtBoxPickUpLocation.Text;
            VehicleRental.DropOffLocation = txtBoxDropOfLocation.Text;
            VehicleRental.DailyRate = decimal.Parse(numPricePerDay.Text);
            VehicleRental.RentalDays = (int)numInitialRentalDays.Value;
            VehicleRental.TotalDue = decimal.Parse(numTotalDueAmount.Text);
            if (!VehicleRental.Save())
            {
                return false;
            }

            _Mode = enMode.Update;
            _LoadDataToUI();
            return true;
        }
        public decimal GetTotalDueAmount() => numTotalDueAmount.Value;
        private void _CalculateTotalDue()
        {
            decimal total = numInitialRentalDays.Value * numPricePerDay.Value;
            numTotalDueAmount.Value = total;
        }
        private void _CalculateRentalDays()
        {
            if (dtRentalEndDate.Value > dtRentalStartDate.Value)
            {
                int days = (dtRentalEndDate.Value - dtRentalStartDate.Value).Days;
                numInitialRentalDays.Value = days;
            }
            else
            {
                numInitialRentalDays.Value = 0;
            }
            _CalculateTotalDue();
        }
        private void dtRentalStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtRentalEndDate.MinDate = dtRentalStartDate.Value.AddDays(1);
            _CalculateRentalDays();
        }
        private void dtRentalEndDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateRentalDays();
        }
        private void numPricePerDay_ValueChanged(object sender, EventArgs e)
        {
            _CalculateTotalDue();
        }
        private void conAddEditRental_Load(object sender, EventArgs e)
        {
            cbInsurance.DataSource = BusinessLayer.Insurances.GetAll();
            cbInsurance.DisplayMember = "Name";
            cbInsurance.ValueMember = "InsuranceID";

            dtRentalStartDate.MinDate = DateTime.Now;
            dtRentalStartDate.MaxDate = DateTime.Now.AddMonths(3);
            dtRentalStartDate.Value = dtRentalStartDate.MinDate;

            dtRentalEndDate.MinDate = dtRentalStartDate.Value.AddDays(1);
            dtRentalEndDate.Value = dtRentalEndDate.MinDate;
            dtRentalEndDate.MaxDate = dtRentalEndDate.Value.AddMonths(3);

            _CalculateRentalDays();
        }
    }
}