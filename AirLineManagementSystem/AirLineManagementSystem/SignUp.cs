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

            Validation vad = new Validation();
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
