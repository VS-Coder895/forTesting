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
    public partial class frmAddInitialPayment : Form
    {
        Payment _Payment = new Payment();
        public frmAddInitialPayment(int RentalID)
        {
            _Payment = new Payment{RentalID = RentalID };
            InitializeComponent();
        }
        private void frmAddInitialPayment_Load(object sender, EventArgs e)
        {
            txtBoxPaymentID.Text = _Payment.PaymentID.ToString();
            txtBoxRentalID.Text = _Payment.RentalID.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Payment.PaymentDate = dtPicPaymentDate.Value;
            _Payment.PaymentNotes = txtBoxPaymentNotes.Text;
            _Payment.InitialPaidAmount = numInitialPaidAmount.Value;
            _Payment.TotalRemainingAmount = numRemainingAmount.Value;

            _Payment.Save();
            this.Close();
        }
        private void numInitialPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            Rental rental = _Payment.GetVehicleRentalByRentalID();
            numRemainingAmount.Value = rental.TotalDue - numInitialPaidAmount.Value;
        }
    }
}
