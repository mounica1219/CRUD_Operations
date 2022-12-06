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
    public partial class Leave : Form
    {
        //path of data base
        string path = "SQL_db.db";

        //database creat debug folder
        string cs = @"URI=file:" + Application.StartupPath + "\\SQL_db.db";


        public Leave()
        {
            InitializeComponent();
        }
        //show data in table
        private void data_show()
        {

            //open a connection to a database
            var con = new SQLiteConnection(cs);

            //opens the database
            con.Open();

            //create a SELECT statement to db
            string stm = "SELECT * FROM leave";

            //execute a query on the database
            var cmd = new SQLiteCommand(stm, con);

            SQLiteDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                //display data in grid view
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }

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
                cmd.CommandText = "INSERT INTO leave(leave_ID,emp_ID,date,status,reason) VALUES(@leave_ID,@emp_ID,@date,@status,@reason)";

                string leave_ID = leave_ID_txt.Text;
                string emp_ID = emp_ID_txt.Text;
                string date = date_txt.Text;
                string status = status_txt.Text;
                string reason = reason_txt.Text;

                cmd.Parameters.AddWithValue("@leave_ID", leave_ID);
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@reason", reason);

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "leave_ID";
                dataGridView1.Columns[1].Name = "emp_ID";
                dataGridView1.Columns[2].Name = "date";
                dataGridView1.Columns[3].Name = " status";
                dataGridView1.Columns[4].Name = "reason";

                string[] row = new string[] { leave_ID, emp_ID, date, status, reason };
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
                cmd.CommandText = "UPDATE leave Set emp_ID=@emp_ID, date=@date, status=@status, reason=@reason where leave_ID=@leave_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@leave_ID", leave_ID_txt.Text);
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID_txt.Text);
                cmd.Parameters.AddWithValue("@date", date_txt.Text);
                cmd.Parameters.AddWithValue("@status", status_txt.Text);
                cmd.Parameters.AddWithValue("@reason", reason_txt.Text);

                cmd.ExecuteNonQuery();

                dataGridView1.Rows.Clear();

                data_show();

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
                cmd.CommandText = "DELETE FROM leave where leave_ID=@leave_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@leave_ID", leave_ID_txt.Text);

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

    }
}



