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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(); // Establishing a Connection

            Employee obj = new Employee(); // Creating an instance of the classs. 

            // start assigning the values
            if (textBox_eno.ReadOnly == false)
            {
                obj.Eno = int.Parse(textBox_eno.Text);
                obj.Ename = textBox_ename.Text;
                obj.Job = textBox_job.Text;
                obj.Salary = decimal.Parse(textBox_salary.Text);
                obj.Dname = textBox_dname.Text;
                db.Employees.InsertOnSubmit(obj);
                db.SubmitChanges();
                MessageBox.Show("Record has been inserted into the system.");
            }
            else {
                obj = db.Employees.SingleOrDefault(E => E.Eno == int.Parse(textBox_eno.Text));
                obj.Ename = textBox_ename.Text;
                obj.Job = textBox_job.Text;
                obj.Salary = decimal.Parse(textBox_salary.Text);
                obj.Dname = textBox_dname.Text;
                db.SubmitChanges();
                MessageBox.Show("Record has been Updated.");
            
            }
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
            textBox_eno.Focus();
        }

        private void close_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
