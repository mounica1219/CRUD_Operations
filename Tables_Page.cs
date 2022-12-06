using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_CRUD_Operations
{
    public partial class Tables_Page : Form
    {
        public Tables_Page()
        {
            InitializeComponent();
        }

        

        private void employee_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main_Page  m = new Main_Page();
            m.Show();
            this.Hide();
        }

        private void payroll_btn_Click(object sender, EventArgs e)
        {
            Payroll p = new Payroll();
            p.Show();
            this.Hide();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();
            this.Hide();
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();

        }

        private void leave_btn_Click(object sender, EventArgs e)
        {
            Leave l = new Leave();
            l.Show();
            this.Hide();

        }
    }
}
