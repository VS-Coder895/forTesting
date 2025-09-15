using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conAddEditInitialPayment : UserControl
    {
        private enum enMode { Update = 0, AddNew = -1 };

        private enMode _Mode = enMode.AddNew;
        public decimal TotalAmount;
        public Payment Payment;
        public conAddEditInitialPayment()
        {
            InitializeComponent();
            Payment = new Payment();
            _Mode = enMode.AddNew;
        }
        public void LoadPayment(Payment payment)
        {
            this.Payment = payment;
            _Mode = enMode.Update;
        }
        private void _LoadDataToUI()
        {
            txtBoxPaymentID.Text = Payment.PaymentID.ToString();
            txtBoxPaymentNotes.Text = Payment.PaymentNotes;
            numInitialPaidAmount.Value = Payment.InitialPaidAmount;
            dtPicPaymentDate.Value = Payment.PaymentDate;
            numRemainingAmount.Value = Payment.TotalRemainingAmount;
        }
        public bool Save()
        {
            if (!Validate())
            {
                return false;
            }
            Payment.PaymentNotes = txtBoxPaymentNotes.Text;
            Payment.InitialPaidAmount = numInitialPaidAmount.Value;
            Payment.PaymentDate = dtPicPaymentDate.Value;
            Payment.TotalRemainingAmount = numRemainingAmount.Value;
            Payment.PaymentStatus = "Partial";
            if (!Payment.Save())
            {
                return false;
            }

            _Mode = enMode.Update;
            _LoadDataToUI();
            return true;
        }
        public void numTotalDue_ValueChanged(object sender, EventArgs e)
        {
            Guna2NumericUpDown con = sender as Guna2NumericUpDown;
            TotalAmount = con.Value;
            numInitialPaidAmount.Maximum = TotalAmount;
            numRemainingAmount.Value = TotalAmount - numInitialPaidAmount.Value;
        }
        private void numInitialPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            if (TotalAmount - numInitialPaidAmount.Value > 0)
            {
                numRemainingAmount.Value = TotalAmount - numInitialPaidAmount.Value;
            }
            else if(numRemainingAmount.Value > 0)
            {
                numRemainingAmount.Value = 0;
                numInitialPaidAmount.Value += numRemainingAmount.Value;
            }
        }
        private void conAddEditInitialPayment_Load(object sender, EventArgs e)
        {
        }
    }
}
