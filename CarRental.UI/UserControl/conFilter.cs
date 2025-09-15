using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conFilter : UserControl
    {
        public EventHandler<EventArgs> Filtered;
        public Type clsType { get; set; }
        public conFilter()
        {
            InitializeComponent();
        }
        bool _CheckLikeInRowInColumn(DataRow row, string col, string word)
        {
            return row[col.ToString()].ToString().ToLower().Contains(word);
        }
        bool _CheckLikeInRow(DataRow row, string word)
        {
            foreach (object col in row.Table.Columns)
            {
                if (row[col.ToString()].ToString().ToLower().Contains(word))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxSearch.Text)) return;
            DataTable records = clsType.GetMethod("GetAll").Invoke(null, null) as DataTable;
            DataRow row = null;

            if (comboBoxFilter.SelectedIndex is 0)
            {
                IEnumerable<DataRow> rows = records.Select().Where(record => _CheckLikeInRow(record, txtBoxSearch.Text.ToLower()));
                if (rows.Count() != 0) row = rows.First();
            }
            else
            {
                IEnumerable<DataRow> rows = records.Select().Where(record => _CheckLikeInRowInColumn(record,
                    comboBoxFilter.SelectedValue.ToString(), txtBoxSearch.Text.ToLower()));
                if (rows.Count() != 0) row = rows.First();

            }

            if (row != null)
            {
                Filtered?.Invoke((int)row[0], EventArgs.Empty);
            }
        }
        public void SetColumns()
        {
            DataTable data = clsType.GetMethod("GetAll").Invoke(null, null) as DataTable;

            DataColumn[] columns = new DataColumn[data.Columns.Count + 1];
            columns[0] = new DataColumn("All");
            data.Columns.CopyTo(columns, 1);
            comboBoxFilter.DataSource = columns;
            comboBoxFilter.SelectedIndex = 0;
        }
        private void conFilter_Load(object sender, EventArgs e)
        {
            if (clsType != null)
            {
                SetColumns();
            }
        }

      
    }
}
