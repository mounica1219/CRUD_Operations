using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import SQLite data provider
using System.Data.SQLite;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;


namespace SQL_CRUD_Operations
{
    public partial class Employee : Form
    {
        //path of data base
        string path = "SQL_db.db";

        //database creat debug folder
        string cs = @"URI=file:" + Application.StartupPath + "\\SQL_db.db";


        public Employee()
        {
            InitializeComponent();
        }
        //show data in table
        private void data_show()
        {
            Console.WriteLine("enter into data_show method");
            //open a connection to a database
            var con = new SQLiteConnection(cs);
            Console.WriteLine("sqlconnection completed");

            //opens the database
            con.Open();
            Console.WriteLine("open");
            //create a SELECT statement to db
            string stm = "SELECT * FROM employee";
            //execute a query on the database
            var cmd = new SQLiteCommand(stm, con);

            SQLiteDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("now data in dr");

            while (dr.Read())
            {
                Console.WriteLine("enter into while loop");
                //display data in grid view
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7));
            }
            Console.WriteLine("while completed");
            con.Close();
        }

        

        //insert data
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO employee(emp_ID,fname,lname,gender,age,contact_add,emp_email,emp_pass) VALUES(@emp_ID,@fname,@lname,@gender,@age,@contact_add,@emp_email,@emp_pass)";

                string EMP_ID = emp_ID_txt.Text;
                string FNAME = fname_txt.Text;
                string LNAME = lname_txt.Text;
                string GENDER = gender_txt.Text;
                string AGE = age_txt.Text;
                string CONTACT_ADD = contact_add_txt.Text;
                string EMP_EMAIL = emp_email_txt.Text;
                string EMP_PASS = emp_pass_txt.Text;

                cmd.Parameters.AddWithValue("@emp_ID", EMP_ID);
                cmd.Parameters.AddWithValue("@fname", FNAME);
                cmd.Parameters.AddWithValue("@lname", LNAME);
                cmd.Parameters.AddWithValue("@gender", GENDER);
                cmd.Parameters.AddWithValue("@age", AGE);
                cmd.Parameters.AddWithValue("@contact_add", CONTACT_ADD);
                cmd.Parameters.AddWithValue("@emp_email", EMP_EMAIL);
                cmd.Parameters.AddWithValue("@emp_pass", EMP_PASS);

                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "emp_ID";
                dataGridView1.Columns[1].Name = "fname";
                dataGridView1.Columns[2].Name = "lname";
                dataGridView1.Columns[3].Name = "gender";
                dataGridView1.Columns[4].Name = "age";
                dataGridView1.Columns[5].Name = "contact_add";
                dataGridView1.Columns[6].Name = "emp_email";
                dataGridView1.Columns[7].Name = "emp_pass";
                string[] row = new string[] { EMP_ID, FNAME, LNAME,GENDER, AGE, CONTACT_ADD, EMP_EMAIL, EMP_PASS };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }

        }

        // update data
        private void update_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE employee Set fname=@fname,lname=@lname,gender=@gender,age=@age,contact_add=@contact_add,emp_email=@emp_email,emp_pass=@emp_pass where emp_ID=@emp_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID_txt.Text);
                cmd.Parameters.AddWithValue("@fname", fname_txt.Text);
                cmd.Parameters.AddWithValue("@lname", lname_txt.Text);
                cmd.Parameters.AddWithValue("@gender", gender_txt.Text);
                cmd.Parameters.AddWithValue("@age", age_txt.Text);
                cmd.Parameters.AddWithValue("@contact_add", contact_add_txt.Text);
                cmd.Parameters.AddWithValue("@emp_email", emp_email_txt.Text);
                cmd.Parameters.AddWithValue("@emp_pass", emp_pass_txt.Text);

                cmd.ExecuteNonQuery();
                Console.WriteLine("query excuted");
                dataGridView1.Rows.Clear();
                Console.WriteLine("data clered on dartagrideview");
                data_show();
                Console.WriteLine("datashow completed");



            }
            catch (Exception)
            {
                Console.WriteLine("cannot update data");
                return;
            }
        }

        // delete data
        private void delete_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM employee where emp_ID=@emp_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID_txt.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }

      

        private void back_btn_Click(object sender, EventArgs e)
        {
            Tables_Page t = new Tables_Page();
            t.Show();
            this.Hide();
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            data_show();
        }

        private void emp_email_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


