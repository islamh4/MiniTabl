using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTabl
{
    internal class Wordtabl
    {
        public void ClosedLoadAddandEdit(Form1 from1)
        {
            from1.index = -1;
            from1.dataTabl.ClearSelection();
        }
        public void AddEdit(Form1 from1, params TextBox[] textBoxes)
        {
            if (from1.index >= 0)
            {
                DataGridViewRow data = from1.dataTabl.Rows[from1.index];
                data.Cells[0].Value = textBoxes[0].Text;
                data.Cells[1].Value = textBoxes[1].Text;
                data.Cells[2].Value = textBoxes[2].Text;
            }
            else
            {
                from1.dataTable.Rows.Add(textBoxes[0].Text, textBoxes[1].Text, textBoxes[2].Text);
            }
        }
        public void AddEditLoad(Form1 from1, params TextBox[] textBoxes)
        {
            if (from1.index >= 0)
            {
                DataGridViewRow row = from1.dataTabl.Rows[from1.index];
                textBoxes[0].Text = row.Cells[0].Value.ToString();
                textBoxes[1].Text = row.Cells[1].Value.ToString();
                textBoxes[2].Text = row.Cells[2].Value.ToString();
            }
        }
        public void Validation(out bool byl,params TextBox[] textBoxes)
        {
            byl = true;
            if (textBoxes[0].Text == "")
            {
                MessageBox.Show("Пустая строка");
                byl = false;
                return;
            }

            if (!DateTime.TryParse(textBoxes[1].Text, out DateTime dateTime))
            {
                MessageBox.Show("Введите дату по формате dd.mm.yyyy");
                byl = false;
                return;
            }
            if (textBoxes[2].Text == "")
            {
                MessageBox.Show("Пустая строка");
                byl = false;
                return;
            }
        }
    }
}

