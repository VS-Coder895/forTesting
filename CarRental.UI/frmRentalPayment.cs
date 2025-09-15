using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class frmRentalPayment : Form
    {
        public frmRentalPayment()
        {

            InitializeComponent();


            conAddRental con = new conAddRental();
            //conAddEditRental con = new conAddEditRental();
            con.Dock = DockStyle.Fill;

            Controls.Add(con);
            Size = new Size(1000, 1000);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void picBoxClosing_Click(object sender, EventArgs e)
        {
        }

        private void frmRentalPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
