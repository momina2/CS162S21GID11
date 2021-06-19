using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class RestoreSeats : Form
    {
        public RestoreSeats()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestoreSeats_Load(object sender, EventArgs e)
        {
            Flight.Obj.addFlightList();
            List<String> flist = new List<String>();
             for (int i=0; i< Flight.Obj.getFlight().Count-1;i++)
            {
                flist.Add(Flight.Obj.getFlight().ElementAt(i).FlightCode);
            }

            comboBox1.DataSource = flist;
                
            comboBox1.DisplayMember = "Flight Code";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                MessageBox.Show("Flight " + comboBox1.SelectedItem + " seats has been restored ","Restore Seats ");
            }
        }
    }
}
