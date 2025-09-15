using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class conAutoFilter : UserControl
    {
        public EventHandler<EventArgs> Filtered;
        private Type _ClassType;
        public conAutoFilter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// هذه الدالة تقوم بتحديد نوع الـنموذج الذي تم تنفيذه و بناء
        /// عليه يتم استدعاء الدالة التي تعرض الجدول الخاص بهذا الكلاس
        /// </summary>
        /// <param name="type">اسم الكلاس</param>
        public void LoadType(Type type)
        {
            _ClassType = type;
        }
        
        bool _CheckLikeInRowInColumn(DataRow row, string col, string word)
        {
            return row[col.ToString()].ToString().ToLower().Contains(word);
        }
        
        /// <summary>
        /// هذه الدالة تقوم بالفلترة فقط على حسب نص البحث
        /// و ترجع قيمة صحيحة لكل صف وجد فيه نفس النص الذي بحث عنه
        /// </summary>
        /// <param name="row">صف من الجدول الذي يتم البحث فيه</param>
        /// <param name="word">نص البحث</param>
        /// <returns></returns>
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
        
        /// <summary>
        /// هذه الدالة تقوم بفلترة الصفوف الظاهرة بناء على نوع الفلترة و النص 
        /// المراد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable records = _ClassType.GetMethod("GetAll").Invoke(null, null) as DataTable;

            // بحث عن النص المراد في كل الصفوف
            if (comboBoxFilter.SelectedIndex is 0)
            {
                // إرجاع كافة الصفوف التي تحتوي على النص الذي تم البحث عنه
                IEnumerable<DataRow> tab = records.Select().Where(record => _CheckLikeInRow(record, txtBoxSearch.Text.ToLower()));

                int numOfMatchedRows = tab.Count();

                if (numOfMatchedRows != 0)
                {
                    // تحديث الجدول
                    records = tab.CopyToDataTable();
                }
                else
                {
                    records.Rows.Clear();
                }
            }
            else
            {
                IEnumerable<DataRow> tab = records.Select().Where(record => _CheckLikeInRowInColumn(record,
                    comboBoxFilter.SelectedValue.ToString(), txtBoxSearch.Text.ToLower()));

                int numOfMatchedRows = tab.Count();

                if (numOfMatchedRows != 0)
                {
                    records = tab.CopyToDataTable();
                }
                else
                {
                    records.Rows.Clear();
                }
            }
            Filtered.Invoke(records, new EventArgs());
        }
        
        /// <summary>
        /// هذه الدالة تقوم باستدعاء جميع أسماء الأعمدة في الجدول الخاص بكلاس معين
        /// و بناء عليه يتم تعبئة مربع الاختيار بهذه الأسماء, كي يتمكن المستخدم
        /// من الفلترة على حسب العمود المراد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conAutoFilter_Load(object sender, EventArgs e)
        {
            if (_ClassType != null)
            {
                DataTable data = _ClassType.GetMethod("GetAll").Invoke(null, null) as DataTable;

                // تحديد عدد الأعمدة
                DataColumn[] columns = new DataColumn[data.Columns.Count + 1];
                // جعل العمود الافتراضي هو "الكل"  س
                columns[0] = new DataColumn("All");
                // يتم التعبئة من الموقع 1 و ذلك لأن الموقع 0 قد تم تعبئته
                data.Columns.CopyTo(columns, 1);
                comboBoxFilter.DataSource = columns;
                comboBoxFilter.SelectedIndex = 0;
            }
        }
        
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxSearch_TextChanged(null, null);
        }
    }
}
