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
    public partial class FlightsUC : UserControl
    {
        public FlightsUC()
        {
            InitializeComponent();
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //autocomplete dynamically 

                SourceBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                SourceBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DestinationBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                DestinationBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                string [] cities = new string[] {"Islamabad","Rawalpindi","Karachi","Lahore","Dera Ghazi Khan","Faisalabad",
                    "Gwadar","Multan","Peshawar","Quetta","Rahim Yar Khan","Sialkot","Turbat",
                    "Bahawalpur","Chashma","Chilas","Chitral","Dalbandin","Dera Ismail Khan",
                    "Gilgit","Gujrat","Hyderabad","Islamkot","Jacobabad","Khuzdar","Larkana",
                    "Muzaffarabad","Nawabshah","Rawalakot","Sibi","Skardu","Sukkur"};

                     auto.AddRange(cities);

                SourceBox.AutoCompleteCustomSource = auto;
                DestinationBox.AutoCompleteCustomSource = auto;

            }

        }

                   
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {

                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                string[] countries = new string[] {"Afghanistan","Algeria","Argentina","Aruba","Australia",
                    "Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados","Belgium","Bermuda",
                    "Bhutan","Bosnia ","Brazil","Canada","Chile","China","Colombia","Costa Rica","Cuba","Denmark","Dominica",
                    "Egypt","Ethiopia","Finland","France","Georgia","Germany","Greece",
                    "Greenland","Hong Kong","Hungary","Iceland","India","Indonesia","Iran","Iraq","Ireland","Isle of Man","Italy",
                    "Jamaica","Japan","Jersey","Kazakhstan","Kenya","Kuwait","Kyrgyzstan","Lebanon","Lesotho","Liberia","Libya","Malaysia",
                    "Maldives","Mexico","Mongolia","Montenegro","Morocco",
                    "Nepal","Netherlands","New Caledonia","New Zealand","Niger","Nigeria","North Korea","Norway","Oman","Pakistan","Palestine",
                    "Panama","Peru","Philippines","Poland","Portugal","Puerto Rico","Qatar","Romania","Russia","Saudi Arabia","Senegal","Serbia","Singapore",
                    "Somalia","South Africa","South Korea","Spain","Sri Lanka","St Lucia","Sudan","Swaziland","Sweden","Switzerland","Syria","Tajikistan",
                    "Thailand","Turkey","Turkmenistan","Uganda","Ukraine","United Arab Emirates","United Kingdom","United States of America","Uzbekistan",
                    "Venezuela","Vietnam","Yemen","Zambia","Zimbabwe" };
                     auto.AddRange(countries);


                DialogResult result = MessageBox.Show("Do you want to add stop ?","Internation Flight", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //layover textbox
                    TextBox Midstop = new TextBox();
                    panel1.Controls.Add(Midstop);
                    Midstop.Location = new Point(265, 94);
                    Midstop.Size = new Size(97, 22);
                 
                    //layover label
                    Label midlabel = new Label();
                    panel1.Controls.Add(midlabel);
                    midlabel.Location = new Point(179, 95);
                    midlabel.Font = new Font("Century Gothic", 14);
                    midlabel.Text = "Layover";


                    //source textbox loaction 
                    SourceBox.Location = new Point(74, 95);
                    SourceBox.Size = new Size(97, 23);
                    label2.Location = new Point(1, 95);

                    //destination textbox loaction
                    DestinationBox.Location = new Point(481, 95);
                    DestinationBox.Size = new Size(117, 23);
                    label3.Location = new Point(368, 95);

                    Midstop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    Midstop.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    Midstop.AutoCompleteCustomSource = auto;
                }

                if (result == DialogResult.No)
                {
                    SourceBox.Location = new Point(109, 95);
                    SourceBox.Size = new Size(186, 23);
                    label2.Location = new Point(25, 95);

                    DestinationBox.Location = new Point(416, 95);
                    DestinationBox.Size = new Size(179, 23);
                    label3.Location = new Point(301, 96);
                }



                SourceBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                SourceBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DestinationBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                DestinationBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SourceBox.AutoCompleteCustomSource = auto;
                DestinationBox.AutoCompleteCustomSource = auto;

            }
        }

        private void SourceBox_TextChanged(object sender, EventArgs e)
        {
            if (SourceBox.Text == DestinationBox.Text)
            {
                MessageBox.Show("Flight not Found !", "Flight Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DestinationBox_TextChanged(object sender, EventArgs e)
        {
            if (SourceBox.Text == DestinationBox.Text)
            {
                MessageBox.Show("Flight not Found !", "Flight Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Now>dateTimePicker1.Value)
            {
                MessageBox.Show("Invalid Date !", "Select Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


           
        }
    }
}
