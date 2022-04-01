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
    public partial class Form7 : Form
    {
        DataClasses1DataContext dc;

        private void LoadData()
        {
            dc = new DataClasses1DataContext();
            displaygrid.DataSource = dc.Employees;
        }
        bool flag = false;
        public Form7()
        {
            InitializeComponent();

            dc = new DataClasses1DataContext();
            var tab = from E in dc.Employees
                      select E;

            displaygrid.DataSource = tab;

            var tab1 = from E in dc.Employees
                       select new { E.Job };

            comboBox1.DataSource = tab1.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;
            flag = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (flag == true)
            {
                displaygrid.DataSource = from E in dc.Employees where E.Job == comboBox1.Text select E;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            displaygrid.DataSource = from E in dc.Employees where E.Job.Contains(comboBox1.Text) select E;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
