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
            string query = "UPDATE  EmployeeInfo SET Name = '" + textBox1.Text + "', Phone# = '" + textBox4.Text + "', CNIC = '" + textBox3.Text + "', Password = '" + textBox5.Text + "'Where ID = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("HO Gya Kam");
        }

        //add data to list
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
           
            

        }
       

        public void ToViewEmployee()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeInfo";
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
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Update";
            btn1.Name = "Update";
            btn1.Text = "Update";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn1);


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Password column
            if(e.ColumnIndex==6)
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
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete Employee
            if (e.ColumnIndex == 0)
            {
                string value = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                con.Open();
                string query = "DELETE FROM EmployeeInfo where Name = '" + value + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                ToViewEmployee();
            }
            //Update Employee
            if (e.ColumnIndex == 1)
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}
