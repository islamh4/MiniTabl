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
        Wordtabl wordtabl = new Wordtabl();
        public AddandEdit()
        {
            InitializeComponent();   
        }
        public AddandEdit(Form1 from)
        {
            from1 = from;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            wordtabl.Validation(out bool byl,textBox1, textBox2, textBox3);
            if (byl)
            {
                wordtabl.AddEdit(from1, textBox1, textBox2, textBox3);
                this.Close();
            }
        }

        private void AddandEdit_Load(object sender, EventArgs e)
        {
            wordtabl.AddEditLoad(from1, textBox1, textBox2, textBox3);
        }

        private void AddandEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            wordtabl.ClosedLoadAddandEdit(from1);
        }
        
    }
}
