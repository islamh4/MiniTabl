using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTabl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable dataTable = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("ФИО", Type.GetType("System.String"));
            dataTable.Columns.Add("Дата рождение", Type.GetType("System.String"));
            dataTable.Columns.Add("Адрес", Type.GetType("System.String"));
            dataTabl.DataSource = dataTable;
            dataTabl.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = -1;
            AddandEdit addandEdit = new AddandEdit(this);
            addandEdit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddandEdit addandEdit = new AddandEdit(this);
            addandEdit.ShowDialog();
        }
        public int index = -1;
        private void dataTabl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataTabl.Rows.Count == 0)
                return;
            if (index >= 0)
            {
                dataTabl.Rows.RemoveAt(index);
            }

            //index = dataTabl.CurrentCell.RowIndex;
            //dataTabl.Rows.RemoveAt(index);
        }

    }
}
