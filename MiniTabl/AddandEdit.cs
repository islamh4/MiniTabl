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
    public partial class AddandEdit : Form
    {
        Form1 from1;
        Form1 form = new Form1();
        public AddandEdit()
        {
            InitializeComponent();   
        }
        public AddandEdit(Form1 from)
        {
            from1 = from;
            InitializeComponent();
        }

        /// <summary>
        /// Обработка нажатия кнопки Сохранить   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (from1.index >= 0)
            {
                DataGridViewRow data = from1.dataTabl.Rows[from1.index];
                data.Cells[0].Value = textBox1.Text;
                data.Cells[1].Value = textBox2.Text;
                data.Cells[2].Value = textBox3.Text;     
            }
            else
            {
                from1.dataTable.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            }
        }

        private void AddandEdit_Load(object sender, EventArgs e)
        {
            if (from1.index >= 0)
            {
                DataGridViewRow row = from1.dataTabl.Rows[from1.index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
        }

        private void AddandEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            from1.index = -1;
            from1.dataTabl.ClearSelection();
        }
    }
}
