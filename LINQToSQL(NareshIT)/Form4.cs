using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQL_NareshIT_
{
    public partial class Form4 : Form
    {
        DataClasses1DataContext db;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           db = new DataClasses1DataContext();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBox_ename.Focus();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
