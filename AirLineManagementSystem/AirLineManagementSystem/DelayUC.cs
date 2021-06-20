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
            update();
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
            
           /* SqlConnection con = new SqlConnection(Configuration.connection);
            con.Open();
            string query = "UPDATE allFlights SET Date = '" + Convert.ToDateTime(dateTimePicker1.Text) + "'Where FlightCode = '" +  comboBox1.SelectedItem + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();*/
            MessageBox.Show("Your Data Has Been Updated successfully, PARWAAZ");
        }

        public void addToComboBox()
        {
            SqlConnection con = new SqlConnection(Configuration.connection);

            con.Open();

            string query = "SELECT * FROM allFlights";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sdr;
            sdr = sc.ExecuteReader();
            try
            {
                while (sdr.Read())
                {
                    string code = sdr.GetString(0);
                    comboBox1.Items.Add(code);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           

        }

        public void search()
        {
            SqlConnection con = new SqlConnection(Configuration.connection);
            con.Open();
            string query = "SELECT * FROM allFlights where FlightCode = '" + comboBox1.Text + "'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sdr;
            sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                // DateTime date;
                // date = Convert.ToDateTime(dateTimePicker1.Text,
                //System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                //dateTimePicker1.Text = sdr["Date"].ToString();
                DateTime date;
                date = Convert.ToDateTime(dateTimePicker1.Text);
                date = Convert.ToDateTime(sdr["Date"]);
                sdr.Close();
            }
            else
            {
                MessageBox.Show("DATE Not Found");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void DelayUC_Load(object sender, EventArgs e)
        {
            addToComboBox();
        }
    }
}
