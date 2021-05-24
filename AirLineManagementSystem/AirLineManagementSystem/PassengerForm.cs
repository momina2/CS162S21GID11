using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Width = button3.Width;
            sidepanel.Top = button3.Bottom;
            sidepanel.Location = button3.Location;


            tabControl1.SelectedTab = CancelPage;
            // tabControl1.BringToFront();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Width = button1.Width;
            sidepanel.Top = button1.Bottom;
            sidepanel.Location = button1.Location;


            tabControl1.SelectedTab = HomePage;
            // tabControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Width = button2.Width;
            sidepanel.Top = button2.Bottom;
            sidepanel.Location = button2.Location;
            if (downpanel.Size == downpanel.MinimumSize)
            {
                downpanel.Size = downpanel.MaximumSize;
                this.downpanel.BringToFront();

            }
            else
                downpanel.Size = downpanel.MinimumSize;
            this.downpanel.BringToFront();


            tabControl1.SelectedTab = FlyPage;
            // tabControl1.BringToFront();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

            downpanel.Size = downpanel.MaximumSize;
            this.downpanel.BringToFront();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = UpdatePage;
            downpanel.Size = downpanel.MinimumSize;
            //this.downpanel.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ViewPage;
            downpanel.Size = downpanel.MinimumSize;
            // this.downpanel.BringToFront();

        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void ViewPage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FlyPage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PassengerinfoPage;
        }

        private void SeatSelection_Click(object sender, EventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Payment;
        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Ticketpage;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            { this.Alert("Visit Booth No # 11"); }
        }
        public void Alert(string msg)
        {
            NotificationForm frm = new NotificationForm();
            frm.showAlert(msg);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SeatSelection;
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            AdminForm Af = new AdminForm();
            Af.Show();
            this.Visible = false;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click_1(object sender, EventArgs e)
        {
            AdminForm Af = new AdminForm();
            Af.Show();
            this.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PassengerinfoPage;
        }

        private void PassengerinfoPage_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SeatSelection;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Payment;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Ticketpage;
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
                string[] cities = new string[] {"Islamabad","Rawalpindi","Karachi","Lahore","Dera Ghazi Khan","Faisalabad",
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
            if (radioButton2.Checked)
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


                SourceBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                SourceBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DestinationBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                DestinationBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SourceBox.AutoCompleteCustomSource = auto;
                DestinationBox.AutoCompleteCustomSource = auto;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Alert("Visit Booth No # 11");
        }
    }
}
