using BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmUpdateReturn : Form
    {
        private Return _Return;
        public frmUpdateReturn(int PaymentID)
        {
            _Return = Return.FindByReturnID(PaymentID);
            InitializeComponent();
        }
        private void UpdateReturn_Load(object sender, EventArgs e)
        {
            txtBoxReturnID.Text = _Return.ReturnID.ToString();
            txtBoxRentalID.Text = _Return.RentalID.ToString();
            dtPicActualReturnDate.Value = _Return.ActualReturnDate;
            txtBoxDamageReport.Text = _Return.DamageReport;
            numActualRentalDays.Value = _Return.ActualRentalDays;
            numConsumedMileage.Value = _Return.ConsumedMileage;
            numAdditionalCharges.Value = _Return.AdditionalCharges;
            numCurrentMileage.Value = _Return.CurrentMileage;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Return.ActualReturnDate = dtPicActualReturnDate.Value;
            _Return.ActualRentalDays = (int)numActualRentalDays.Value;
            _Return.DamageReport = txtBoxDamageReport.Text;
            _Return.ConsumedMileage = numConsumedMileage.Value;
            _Return.AdditionalCharges = numAdditionalCharges.Value;
            _Return.CurrentMileage = numCurrentMileage.Value;

            _Return.Save();
            this.Close();
        }
    }
}
