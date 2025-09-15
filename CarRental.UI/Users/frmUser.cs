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

namespace CarRental.UI.Users
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            conFilter.LoadType(typeof(User));
            conFilter.Filtered += (s, _e) =>
            {
                _RefreshUsers(s as DataTable);
            };

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            _RefreshUsers(User.GetAll());

        }
        void _RefreshUsers(DataTable data)
        {
            dgvShowUsers.DataSource = data;
            lblCounter.Text = data.Rows.Count.ToString();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            
            frm.Show();
            _RefreshUsers(User.GetAll());
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm=new frmAddEditUser((int)dgvShowUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUsers(User.GetAll());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvShowUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a User to delete.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(dgvShowUsers.CurrentRow.Cells[0].Value?.ToString(), out int UserId))
            {
                MessageBox.Show("Invalid User ID.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show($"Are you sure you want to delete this User (ID: {UserId})?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {



                if (User.DeleteByUserID(UserId))
                {
                    MessageBox.Show("User deleted successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conFilter.txtBoxSearch_TextChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to delete the User. It may already be deleted or in use.",
                                  "Deletion Failed",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the User: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void conFilter_Load(object sender, EventArgs e)
        {

        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvShowUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
