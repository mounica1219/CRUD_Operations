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
    public partial class Payroll : Form
    {
        //path of data base
        string path = "SQL_db.db";

        //database creat debug folder
        string cs = @"URI=file:" + Application.StartupPath + "\\SQL_db.db";


        public Payroll()
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
            string stm = "SELECT * FROM payroll";

            //execute a query on the database
            var cmd = new SQLiteCommand(stm, con);

            SQLiteDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                //display data in grid view
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7));
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
                cmd.CommandText = "INSERT INTO payroll(payroll_ID,emp_ID,job_ID,salary_ID,leave_ID,date,report,total_amount) VALUES(@payroll_ID,@emp_ID,@job_ID,@salary_ID,@leave_ID,@date,@report,@total_amount)";

               
                cmd.Parameters.AddWithValue("@payroll_ID", payroll_ID_txt.Text);
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID_txt.Text);
                cmd.Parameters.AddWithValue("@job_ID", job_ID_txt.Text);
                cmd.Parameters.AddWithValue("@salary_ID", salary_ID_txt.Text);
                cmd.Parameters.AddWithValue("@leave_ID", leave_ID_txt.Text);
                cmd.Parameters.AddWithValue("@date", date_txt.Text);
                cmd.Parameters.AddWithValue("@report", report_txt.Text);
                cmd.Parameters.AddWithValue("@total_amount", total_amount_txt.Text);

                string[] row = new string[] { payroll_ID, emp_ID, job_ID, salary_ID, leave_ID, date, report, total_amount };
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
                cmd.CommandText = "UPDATE payroll Set emp_ID=@emp_ID,job_ID=@job_ID,salary_ID=@salary_ID,leave_ID=@leave_ID,date=@date,report=@report,total_amount=@total_amount where payroll_ID=@payroll_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@payroll_ID", payroll_ID_txt.Text);
                cmd.Parameters.AddWithValue("@emp_ID", emp_ID_txt.Text);
                cmd.Parameters.AddWithValue("@job_ID", job_ID_txt.Text);
                cmd.Parameters.AddWithValue("@salary_ID", salary_ID_txt.Text);
                cmd.Parameters.AddWithValue("@leave_ID", leave_ID_txt.Text);
                cmd.Parameters.AddWithValue("@date", date_txt.Text);
                cmd.Parameters.AddWithValue("@report", report_txt.Text);
                cmd.Parameters.AddWithValue("@total_amount", total_amount_txt.Text);

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
                cmd.CommandText = "DELETE FROM payroll where payroll_ID=@payroll_ID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@payroll_ID", payroll_ID_txt.Text);

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



