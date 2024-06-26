﻿using System;
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
    public partial class Department : Form
    {
        //path of data base
        string path = "SQL_db.db";

        //database creat debug folder
        string cs = @"URI=file:" + Application.StartupPath + "\\SQL_db.db";


        public Department()
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
            string stm = "SELECT * FROM department";

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
                cmd.CommandText = "INSERT INTO department(job_ID,job_dept,name,description,salary_range) VALUES(@job_ID,@job_dept,@name,@description,@salary_range)";

                string job_ID = job_ID_txt.Text;
                string job_dept = job_dept_txt.Text;
                string name = name_txt.Text;
                string description = description_txt.Text;
                string salary_range = salary_range_txt.Text;

                cmd.Parameters.AddWithValue("@job_ID", job_ID);
                cmd.Parameters.AddWithValue("job_dept", job_dept);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@salary_range", salary_range);

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "job_ID";
                dataGridView1.Columns[1].Name = "job_dept";
                dataGridView1.Columns[2].Name = "name";
                dataGridView1.Columns[3].Name = " description";
                dataGridView1.Columns[4].Name = "salary_range";
                
                string[] row = new string[] { job_ID, job_dept, name, description, salary_range };
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
                cmd.CommandText = "UPDATE department Set job_dept=@job_dept, name=@name, description=@description, salary_range=@salary_range where job_ID=@job_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@job_ID", job_ID_txt.Text);
                cmd.Parameters.AddWithValue("@job_dept", job_dept_txt.Text);
                cmd.Parameters.AddWithValue("@name", name_txt.Text);
                cmd.Parameters.AddWithValue("@description", description_txt.Text);
                cmd.Parameters.AddWithValue("@salary_range", salary_range_txt.Text);

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
         //delete data
          private void delete_btn_Click(object sender, EventArgs e)
          {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM department where job_ID=@job_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@job_ID", job_ID_txt.Text);

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



