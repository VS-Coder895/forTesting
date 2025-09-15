using BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
//using BusinessLayer;

namespace CarRental.UI
{
    public partial class frmReturn : Form
    {
        private DataTable _Returns;
        public frmReturn()
        {
            InitializeComponent();
        }
        private void _RefreshData()
        {
            _Returns = Return.GetAll();
            dataGridViewReturns.DataSource = FilterPayments(txtBoxSearch.Text, comboBoxFilter.SelectedValue.ToString());
        }
        private DataTable FilterPayments(string FilteringWord, string ColumnName)
        {

            if (string.IsNullOrEmpty(FilteringWord)) _Returns.DefaultView.RowFilter = null;

            else if (ColumnName == "All")
            {
                _Returns.DefaultView.RowFilter = $@"CONVERT(ReturnID, System.String) LIKE '%{FilteringWord}%'
                    OR CONVERT(RentalID, System.String) LIKE '%{FilteringWord}%'
                    OR CONVERT(ActualRentalDays, System.String) LIKE '%{FilteringWord}%' 
                    OR CONVERT(ActualReturnDate ,System.String) LIKE '%{FilteringWord}%'
                    OR DamageReport LIKE '%{FilteringWord}%' 
                    OR CONVERT(AdditionalCharges, System.String) LIKE '%{FilteringWord}%'
                    OR CONVERT(CurrentMileage, System.String) LIKE '%{FilteringWord}%' 
                    OR CONVERT(ConsumedMileage, System.String) LIKE '%{FilteringWord}%'";
            }
            else
            {
                _Returns.DefaultView.RowFilter = $"CONVERT({ColumnName}, System.String) LIKE '%{FilteringWord}%'";
            }

            return _Returns.DefaultView.ToTable();
        }
        private void frmReturn_Load(object sender, EventArgs e)
        {
            _Returns = BusinessLayer.Return.GetAll();
            DataColumn[] columns = new DataColumn[_Returns.Columns.Count + 1];
            columns[0] = new DataColumn("All");
            _Returns.Columns.CopyTo(columns, 1);
            comboBoxFilter.DataSource = columns;
            comboBoxFilter.SelectedIndex = 0;
            comboBoxFilter.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDown;

            _RefreshData();
        }
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewReturns.DataSource = FilterPayments(txtBoxSearch.Text, comboBoxFilter.SelectedValue.ToString());
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewReturns.DataSource = FilterPayments(txtBoxSearch.Text, comboBoxFilter.SelectedValue.ToString());
        }
        private void DetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnDetails frmDetails = new frmReturnDetails((int)
                dataGridViewReturns.Rows[dataGridViewReturns.CurrentCell.RowIndex].Cells[0].Value);
            frmDetails.ShowDialog();
        }
        private void UpdateStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateReturn frmUpdate = new frmUpdateReturn((int)
                dataGridViewReturns.Rows[dataGridViewReturns.CurrentCell.RowIndex].Cells[0].Value);
            frmUpdate.ShowDialog();
            _RefreshData();
        }
        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            Return.DeleteByReturnID((int)dataGridViewReturns.Rows[dataGridViewReturns.CurrentCell.RowIndex].Cells[0].Value);
            _RefreshData();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Guna2GroupBox con = (sender as Guna2PictureBox).Parent as Guna2GroupBox;
            con.Visible = false;
        }
    }
}
