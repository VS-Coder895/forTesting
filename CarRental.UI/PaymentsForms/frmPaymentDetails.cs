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
    public partial class frmPaymentDetails : Form
    {
        private int _PaymentID;
        public frmPaymentDetails(int ID)
        {
            _PaymentID = ID;
            InitializeComponent();
        }
        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {

            Payment payment = BusinessLayer.Payment.FindByPaymentID(_PaymentID);

            lblPaymentID.Text = payment.PaymentID.ToString();
            lblRentalID.Text = payment.RentalID.ToString();
            lblPaymentDate.Text = payment.PaymentID.ToString();
            lblPaymentStatus.Text = payment.PaymentStatus;
            lblPaymentNotes.Text = payment.PaymentNotes;
            lblRefundedAmount.Text = payment.TotalRefundedAmount.ToString();
            lblInitialPaidAmount.Text = payment.InitialPaidAmount.ToString();
            lblRemainingAmount.Text = payment.TotalRemainingAmount.ToString();
            lblActualFinalDueAmount.Text = payment.ActualFinalAmountDue.ToString();
            lblUpdatedAt.Text = payment.UpdatedPaymentDate.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
