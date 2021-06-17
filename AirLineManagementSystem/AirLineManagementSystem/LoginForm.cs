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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Configuration.connection);

        public void searchFromDB()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeInfo where ID = '" + textBox2.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sdr;
            sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                PasswordBox.Text = (sdr["Name"].ToString());
                textBox1.Text = (sdr["Password"].ToString());
            }
            else
            {
                MessageBox.Show("You Might not have been Registered");
            }
            con.Close();
            MessageBox.Show("\tWelcome!!, Airline Management System");


        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchFromDB();
            ProgressBar PB = new ProgressBar();
            PB.Show();

          

        
                    
        }

        private void Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Password.Checked)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
