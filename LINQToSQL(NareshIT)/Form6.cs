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
    public partial class Form6 : Form
    {
        DataClasses1DataContext dc;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dc = new DataClasses1DataContext();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            int?Eno = null;
            dc.Employee_Insert(textBox_ename.Text, textBox_job.Text, decimal.Parse(textBox_salary.Text), textBox_dname.Text, ref Eno);
            textBox_eno.Text = Eno.ToString();
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
