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
    public partial class frmReturnDetails : Form
    {
        private int _ReturnID;
        public frmReturnDetails(int ID)
        {
            _ReturnID = ID;
            InitializeComponent();
        }
        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {

            Return returnObj = Return.FindByReturnID(_ReturnID);

            lblReturnID.Text = returnObj.ReturnID.ToString();
            lblRentalID.Text = returnObj.RentalID.ToString();
            lblActualRentalDays.Text = returnObj.ActualRentalDays.ToString();
            lblActualReturnDate.Text = returnObj.ActualReturnDate.ToString();
            lblDamageReport.Text = returnObj.DamageReport;
            lblConsumedMileage.Text = returnObj.ConsumedMileage.ToString();
            lblAdditionalCharges.Text = returnObj.AdditionalCharges.ToString();
            lblCurrentMileage.Text = returnObj.CurrentMileage.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
