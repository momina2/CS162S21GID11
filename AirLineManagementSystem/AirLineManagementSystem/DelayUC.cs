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
    public partial class DelayUC : UserControl
    {
        public DelayUC()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now > dateTimePicker1.Value)
            {
                MessageBox.Show("Invalid Date !", "Select Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void update()
        {
            
            SqlConnection con = new SqlConnection(Configuration.connection);
            con.Open();
            string query = "UPDATE allFlights SET Date = '" + dateTimePicker1.Text  + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Data Has Been Updated successfully, PARWAAZ");
        }

        public void search()
        {
            SqlConnection con = new SqlConnection(Configuration.connection);

            con.Open();
            string query = "SELECT * FROM allFlights where FlightCode = '" + textBox2.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sdr;
            sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                dateTimePicker1.Text = (sdr["Date"].ToString());

            }
            else
            {
                MessageBox.Show("Data Not Found\nPlease Enter Valid flight code");
            }
            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //searching the flight using flight code to change the time 
            search();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
