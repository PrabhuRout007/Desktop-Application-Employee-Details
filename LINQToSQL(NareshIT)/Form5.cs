using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LINQToSQL_NareshIT_
{
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            ISingleResult<Employee_SelectResult> tab = dc.Employee_Select("QA");
            datagrid2.DataSource = tab;
        }
    }
}
