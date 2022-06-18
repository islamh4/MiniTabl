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
        AddEditDeleete addEditDeleete = new AddEditDeleete();
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable dataTable = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            addEditDeleete.FormLoad(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEditDeleete.Add(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEditDeleete.Edit(this);
        }
        public int index = -1;
        private void dataTabl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addEditDeleete.Delete(this);
        }

    }
}
