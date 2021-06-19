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
        string namecheck  = null;
         string passwordcheck = null;
        bool flag = false;

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
               namecheck  = (sdr["Name"].ToString());
                passwordcheck = (sdr["Password"].ToString());
                if(namecheck==NametextBox.Text && passwordcheck==PasswordtextBox.Text)
                {
                    MessageBox.Show("\tWelcome!!, Airline Management System");
                    flag = true;
                    
                }
               
                else
                {
                    MessageBox.Show("Invalid Credentials ");
                    textBox2.Text = "";
                    NametextBox.Text = "";
                    PasswordtextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("You Might not have been Registered");
            }
            con.Close();
          


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("#") || !textBox2.Text.Contains("#AMS") || !textBox2.Text.Contains("AMS") || NametextBox.Text.Contains("[0-9]"))
            {
                MessageBox.Show("Invalid Pattern for the ID\n Please Re-check");
                textBox2.Text = null;
            }
            if (NametextBox.Text.Contains("[0-9]"))
            {
                MessageBox.Show("Invalid credentials for name","RE-CHECK",MessageBoxButtons.OK,MessageBoxIcon.Information);
                NametextBox.Text = null;
            }
            else
            {
                searchFromDB();
                if (flag)
                {
                    ProgressBar PB = new ProgressBar();
                    PB.Show();
                }
            }
        }

        private void Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Password.Checked)
            {
               PasswordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordtextBox.UseSystemPasswordChar = true;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
