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
    public partial class Form1 : Form
    {
        DataClasses1DataContext db;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            db = new DataClasses1DataContext();
            dgview.DataSource = db.Employees;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            LoadData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            if (dgview.SelectedRows.Count > 0)
            {
                f.textBox_eno.ReadOnly = true;
                f.clear.Enabled = false;
                f.save.Text = "Update";
                f.textBox_eno.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                f.textBox_ename.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox_job.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox_salary.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox_dname.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                LoadData();
            }
            else {
                MessageBox.Show("Please Select a record for Updation" ,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dgview.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are You Sure of Deleting the record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Eno = Convert.ToInt32(dgview.SelectedRows[0].Cells[0].Value);

                    Employee obj = db.Employees.SingleOrDefault(E=> E.Eno == Eno);
                    db.Employees.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please Select a record for Deletion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
