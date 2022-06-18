using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTabl
{
    internal class AddEditDeleete
    {
        public void Delete(Form1 form1)
        {
            if (form1.dataTabl.Rows.Count == 0)
            {
                MessageBox.Show("Нету строки!");
                return;
            }
            if (form1.dataTabl.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            if (form1.index >= 0)
            {
                form1.dataTabl.Rows.RemoveAt(form1.index);
            }
            
        }
        public void FormLoad(Form1 form1)
        {
            form1.dataTable.Columns.Add("ФИО", Type.GetType("System.String"));
            form1.dataTable.Columns.Add("Дата рождение", Type.GetType("System.String"));
            form1.dataTable.Columns.Add("Адрес", Type.GetType("System.String"));
            form1.dataTabl.DataSource = form1.dataTable;
            form1.dataTabl.RowHeadersVisible = false;
        }
        public void Add(Form1 form1)
        {
            form1.index = -1;
            AddandEdit addandEdit = new AddandEdit(form1);
            addandEdit.ShowDialog();
        }
        public void Edit(Form1 form1)
        {
            if (form1.dataTabl.Rows.Count == 0)
            {
                MessageBox.Show("Нету строки!");
                return;
            }
            if (form1.dataTabl.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            AddandEdit addandEdit = new AddandEdit(form1);
            addandEdit.ShowDialog();
        }
    }
}
