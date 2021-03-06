﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Hooks in SQL functions such as writers, readers, etc.

namespace ISYS4283
{
    public partial class Form1 : Form
    {
        //Establishes Global SQL rules and information
        string connectionString = "Data Source=essql1.walton.uark.edu;" + "Initial Catalog=ISYS4283S2024;" + "User ID=ISYS4283S2024;password=HC23dcv$";
        string SQL = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        public Form1()
        {
            //Launches Form1
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Populates Student Dropdown
            connection = new SqlConnection(connectionString);
            SQL = "SELECT Student_ID FROM Student";
            connection.Open();
            command = new SqlCommand(SQL, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cboxStudent.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits Application
            Application.Exit();
        }

        private void cboxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populates Course List

            connection = new SqlConnection(connectionString);
            SQL = "SELECT Course_ID FROM Course";
            connection.Open();
            command = new SqlCommand(SQL, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lboxCourse.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();

            //Populates Data Grid View

            var sql2 = "'SELECT * FROM Registration WHERE Student_ID =  '" + cboxStudent.SelectedItem.ToString() + "'";
            var dataadapter = new SqlDataAdapter(sql2, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            dgvRegistration.DataSource = ds.Tables[0];
        }
    }
}
