using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class AddAirline : UserControl
      
    {
        SqlConnection con = new SqlConnection(Configuration.connection);
        AirLine airlineobj = new AirLine();
        public AddAirline()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            airlineobj.AirLineName = textBox1.Text;
            airlineobj.Description = richTextBox1.Text;
            if(checkBox1.Checked)
            {
                airlineobj.AirLineStatus = "Active";
            }
            else
            {
                airlineobj.AirLineStatus = "Not Active";
            }
            airlineobj.AirLineCode = "#143";
            AirLine.Obj.AddAirLineList(airlineobj);

            con.Open();
            String query = "INSERT INTO AirlineData (AirlineCode,AirlineName,Status,Description) VALUES ('" + airlineobj.AirLineCode  + "','" + airlineobj.AirLineName + "','" + airlineobj.AirLineStatus +"','" + airlineobj.Description + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("BALLEY BALLEY", "Hogyaa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ToViewAirlines();
        }

        private void AddAirline_Load(object sender, EventArgs e)
        {
            ToViewAirlines();
            
        }
        public void ToViewAirlines()
        {
            con.Open();
            string query = "SELECT * FROM AirlineData";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
