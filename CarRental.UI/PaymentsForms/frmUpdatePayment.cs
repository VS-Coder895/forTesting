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
    public partial class frmUpdatePayment : Form
    {
        private Payment _payment;
        public frmUpdatePayment(int PaymentID)
        {
            _payment = Payment.FindByPaymentID(PaymentID);
            InitializeComponent();
        }

        private int _GetIndexOfPaymentStatus(string Status)
        {
            switch (Status.ToLower())
            {
                case "partial":
                    return 0;
                case "paid":
                    return 1;
            }
            return -1;
        }
        private void _ChangeStatusOfEntries()
        {
            dtPicUpdatedAt.Enabled = _CheckPayment();
            numRefundedAmount.Enabled = dtPicUpdatedAt.Enabled;
            numActualFinalDueAmount.Enabled = dtPicUpdatedAt.Enabled;
        }
        private bool _CheckPayment()
        {
            if (comboBoxPaymentStatus.SelectedIndex == 0) return false;
            return true;
        }
        private void UpdatePayment_Load(object sender, EventArgs e)
        {
            _ChangeStatusOfEntries();

            txtBoxPaymentID.Text = _payment.PaymentID.ToString();
            txtBoxRentalID.Text = _payment.RentalID.ToString();
            dtPicPaymentDate.Value = _payment.PaymentDate;
            comboBoxPaymentStatus.SelectedIndex = _GetIndexOfPaymentStatus(_payment.PaymentStatus);
            txtBoxPaymentNotes.Text = _payment.PaymentNotes;
            numRefundedAmount.Value = _payment.TotalRefundedAmount?? 0;
            numInitialPaidAmount.Value = _payment.InitialPaidAmount;
            numRemainingAmount.Value = _payment.TotalRemainingAmount;
            numActualFinalDueAmount.Text = _payment.ActualFinalAmountDue.ToString();
            
            if ((dtPicUpdatedAt.Enabled = _CheckPayment()) && _payment.UpdatedPaymentDate != null)
            {
                dtPicUpdatedAt.Value = (DateTime)_payment.UpdatedPaymentDate;
            }
            else
            {
                dtPicUpdatedAt.Text = null;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _payment.PaymentDate = dtPicPaymentDate.Value;
            _payment.PaymentStatus = comboBoxPaymentStatus.SelectedItem.ToString();
            _payment.PaymentNotes = txtBoxPaymentNotes.Text;
            _payment.TotalRefundedAmount = numRefundedAmount.Value;
            _payment.InitialPaidAmount = numInitialPaidAmount.Value;
            _payment.TotalRemainingAmount = numRemainingAmount.Value;
            _payment.ActualFinalAmountDue = decimal.Parse(numActualFinalDueAmount.Text);

            _payment.Save();
            this.Close();
        }

        private void comboBoxPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ChangeStatusOfEntries();
        }
    }
}
