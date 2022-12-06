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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tables_Page t = new Tables_Page();
            t.Show();
            this.Hide();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
