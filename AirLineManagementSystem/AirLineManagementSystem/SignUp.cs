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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Agreement a = new Agreement();
            a.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            Validation vad = new Validation();
            if (textBox1.Text.Contains("[0-9]") || !textBox1.Text.Contains(" "))
            {
                MessageBox.Show("You might not have enterred your full name\n\t\tOR\nYou might have added digits in Name Field","RE-CHECK",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                textBox1.Text = null;

            }
            if (!vad.isValidCNIC(textBox3.Text))
            {
                MessageBox.Show("Invalid Cnic", "RE-CHECK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Text = null;
            }
            if (!vad.isValidPhoneNum(textBox4.Text))
            {
                MessageBox.Show("Invalid Phone Number", "RE-CHECK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Text = null;
            }
            if (textBox2.Text.Contains("[0-9]") || textBox2.Text.Contains("[a-z]") || textBox2.Text.Contains("[A-Z]"))
            {
                MessageBox.Show("Your Password must contain: \n1. Upper Case\n2. Lower Case\n3. Digits", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = null;            
            }
           
            else
            {
                string s = "#AMS" + vad.randomID();
                SqlConnection con = new SqlConnection(Configuration.connection);
                con.Open();
                string query = "INSERT INTO EmployeeInfo (ID,Name,Phone#,CNIC,Password) VALUES ('" + s + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Welcome to the Airline Management System\nPlease Note Your ID\n\tYour ID is: " + s);
                PassengerForm pf = new PassengerForm();
                pf.Show();
            }
        }
    }
}
