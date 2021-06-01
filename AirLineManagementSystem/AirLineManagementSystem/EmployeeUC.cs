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
        Employee e = new Employee();
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
            string query = "INSERT INTO EmployeeData (ID,Name,Phone#,CNIC,Password) VALUES ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("HO GYAAAA BALLAY BALLAY!!!");

            ToViewEmployee();
            
            //AddToList();
        }

        public void AddToList(string emp)
        {
            e=new Employee();
            List<Employee> data = new List<Employee>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = emp;
            IDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                 e = new Employee();

                e.Name = reader["Name"].ToString();
                e.PhoneNumber = reader["PhoneNumber"].ToString();
                e.CNIC = reader["CNIC"].ToString();
                e.EmployeeId = reader["EmployeeId"].ToString();

                data.Add(e);
            }
            for (int i = 0; i < data.Count; i++)
            {
                MessageBox.Show(e.Name); 
                MessageBox.Show("Nahi hoya");
               

            }
            MessageBox.Show("Nahi hoya");

        }
        //public void AddToList()
        //{
           
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

       // }

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

        private void EmployeeUC_Load(object sender, EventArgs e)
        {
            ToViewEmployee();
            // AddToList();
            //Button in Table
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Delete";
            btn.Name = "Delet";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Password column
            if(e.ColumnIndex==5)
            {
                if(e.Value!=null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Auto fill text boxes
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete Employee
            if (e.ColumnIndex == 0)
            {
                string value = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                con.Open();
                string query = "DELETE FROM EmployeeData where Name = '" + value + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                // MessageBox.Show("Ja Ja Tur Ja ");
                ToViewEmployee();
            }
        }
    }
}
