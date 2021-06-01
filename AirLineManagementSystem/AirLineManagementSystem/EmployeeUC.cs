using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirLineManagementSystem
{
    public partial class EmployeeUC : UserControl
    {
        SqlConnection con = new SqlConnection(Configuration.connection);
        public EmployeeUC()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO EmployeeData (ID,Name,Phone#,CNIC) VALUES ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("HO GYAAAA BALLAY BALLAY!!!");

            ToViewEmployee();
            AddToList();
        }

        public void AddToList(string emp)
        {
            List<Employee> data = new List<Employee>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = emp;
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee e = new Employee();

                e.Name = reader["Name"].ToString();
                e.PhoneNumber = reader["PhoneNumber"].ToString();
                e.CNIC = reader["CNIC"].ToString();
                e.EmployeeId = reader["EmployeeId"].ToString();

                data.Add(e);
            }
            
        }
        public void AddToList()
        {
           
            /*SqlCommand cmd = new SqlCommand();
          
            List<Employee> Data = new List<Employee>();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT distinct column1 FROM testTable"; // Changed
            SqlDataReader dr = cmd.ExecuteReader();  // Changed
            while (dr.Read())
            {
                Data.Add(dr.GetValue(0).ToString());  // Changed
            }

            foreach (string p in Data)
            {
                Response.Write(p);
            }*/

            /* List<Employee> data = new List<Employee>();
             Employee e = new Employee();
             string a = textBox1.Text;
             string b = textBox2.Text;
             string c = textBox3.Text;
             string d = textBox4.Text;
             e.EmployeeId = b;
             e.Name = a;
             e.PhoneNumber = c;
             e.CNIC = d;
             data.Add(e);
             Console.WriteLine(data);*/



            //   con.Open();
            //      SqlCommand sqlCommand = new SqlCommand("SELECT * FROM EmployeeData", con);
            //      SqlDataReader reader = sqlCommand.ExecuteReader();
            //  //while (reader.Read())
            // {
            //e.EmployeeId = (string)reader["a"];
            // e.Name = (string)reader["Name"];
            // e.PhoneNumber = (string)reader["PhoneNumber"];
            //e.CNIC = (string)reader["CNIC"];
            // data.Add(e);
            // }
            // Console.WriteLine(data);
            //con.Close();

        }

        public void ToViewEmployee()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeData";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
