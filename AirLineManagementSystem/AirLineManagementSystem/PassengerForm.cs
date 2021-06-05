using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf.parser;
using System.Linq;

namespace AirLineManagementSystem
{
    public partial class PassengerForm : Form
    {
      public int totalseats=0;
      public int click = 1;
      public bool nextPage = false;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                label60.Text = "Economy";
            }
            else
            {
                label60.Text = "Business";
            }
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
            downpanel.Size = downpanel.MinimumSize;

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
            LoginForm Af = new LoginForm();
            //AdminForm Af = new AdminForm();
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
            if(nextPage==true)
            tabControl1.SelectedTab = PassengerinfoPage;
            else
            MessageBox.Show("Select  Your Flight ", "Parwaz Airlines", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PassengerinfoPage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SeatSelection;
           
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (totalseats == numericUpDown2.Value)
            { tabControl1.SelectedTab = Payment; }
            else
            {
                MessageBox.Show("Select More Seats", "Seat Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }

        int amount = 0;

        private void button44_Click(object sender, EventArgs e)
        {
            if (click != numericUpDown2.Value)
            {
                MessageBox.Show("Enter Passenger's Data", "Passenger Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
               
                amount = amount + 4000;
                

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

                amount = amount +10000;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Adding Passengers To database
            addPassenger();

            NameBox.Text = "";
            PassBox.Text = "";
            CNICBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";

            NameBox.PlaceholderText = "Name";
            PassBox.PlaceholderText = "Password";
            CNICBox.PlaceholderText = "CNIC #";
            PhoneBox.PlaceholderText = "Phone #";
            EmailBox.PlaceholderText = "Email";

            if (click == numericUpDown2.Value)
            {
                MessageBox.Show("Passengers data had been added", "Passenger Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameBox.Enabled = false;
                PassBox.Enabled = false;
                CNICBox.Enabled = false;
                PhoneBox.Enabled = false;
                EmailBox.Enabled = false;

            }
            click++;
            string V = amount + 500.ToString();
            textBox26.Text = V;

        }
      
        SqlConnection con = new SqlConnection(Configuration.connection);
       

        private void button8_Click(object sender, EventArgs e)
        {
            if(label60.Text=="Economy")
            {
                label44.Text = "11 E";
                label61.Text = "11 E";
                amount = amount + 1000;
                label67.Text = "1000";
                label62.Text = "11 E";
            }
            else
            {
                label44.Text = "11 B";
                label61.Text = "11 B";
                amount = amount + 2000;
                label67.Text = "1000";
                label62.Text = "11 B";

            }
            st1.Enabled=false;
            totalseats++;
            CheckSeats();
            st1.BackColor = Color.LimeGreen;

        }

        private void button52_Click(object sender, EventArgs e)
        {
            DisplayMessage();
        }

      
            private void button51_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "13 E";
                label61.Text = "13 E";
                label67.Text = "1000";
                label62.Text = "13 E";
                amount = amount + 1000;



            }
            else
                {
                label44.Text = "13 B";
                label61.Text = "13 B";
                label67.Text = "2000";
                label62.Text = "13 B";
                amount = amount + 2000;



            }
            st2.Enabled = false;
            totalseats++;
            CheckSeats();
            st2.BackColor = Color.LimeGreen;
            
        }

        private void button50_Click(object sender, EventArgs e)
        {
            DisplayMessage();
        }
            private void button49_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "15 E";
                label61.Text = "15 E";
                label67.Text = "1000";
                amount = amount + 1000;


                label62.Text = "15 E";
            }
            else
                {
                label44.Text = "15 B";
                label61.Text = "15 B";
                label67.Text = "2000";
                label62.Text = "15 B";
                amount = amount + 2000;


            }
            st3.Enabled = false;
            totalseats++;
            CheckSeats();
            st3.BackColor = Color.LimeGreen;
        }
        

            private void button48_Click(object sender, EventArgs e)
            {

            DisplayMessage();
        }

            private void button47_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "17 E";
                label61.Text = "17 E";
                label67.Text = "1000";
                label62.Text = "17 E";
                amount = amount + 1000;


            }
            else
                {
                label44.Text = "17 B";
                label61.Text = "17 B";
                label67.Text = "2000";
                label62.Text = "17 B";
                amount = amount + 2000;


            }
            st4.Enabled = false;
            totalseats++;
            CheckSeats();
            st4.BackColor = Color.LimeGreen;

            
        }

            private void button46_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button15_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "19 E";
                label61.Text = "19 E";
                label67.Text = "1000";
                amount = amount + 1000;

                label62.Text = "19 E";

            }
            else
                {
                label44.Text = "19 B";
                label61.Text = "19 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "19 B";

            }
            st5.Enabled = false;
            totalseats++;
            CheckSeats();
            st5.BackColor = Color.LimeGreen;
        }

            private void button14_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button13_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "21 E";
                label61.Text = "21 E";
                amount = amount + 1000;

                label67.Text = "1000";
                label62.Text = "21 E";

            }
            else
                {
                label44.Text = "21 B";
                label61.Text = "21 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "21 B";

            }
            st6.Enabled = false;
            st6.BackColor = Color.LimeGreen;
            totalseats++;
            CheckSeats();
        }

            private void button12_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button11_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "23 E";
                label61.Text = "23 E";
                amount = amount + 1000;

                label67.Text = "1000";
                label62.Text = "23 E";

            }
            else
                {
                label44.Text = "23 B";
                label61.Text = "23 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "23 B";

            }
            st7.Enabled = false;
            totalseats++;
            CheckSeats();
            st7.BackColor = Color.LimeGreen;
        }

            private void button10_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button33_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "25 E";
                label61.Text = "25 E";
                amount = amount + 1000;

                label67.Text = "1000";
                label62.Text = "25 E";

            }
            else
                {
                label44.Text = "25 B";
                label61.Text = "25 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "25 B";

            }
            st8.Enabled = false;
            totalseats++;
            CheckSeats();
            st8.BackColor = Color.LimeGreen;
        }

            private void button16_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button40_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "27 E";
                label61.Text = "27 E";
                amount = amount + 1000;

                label67.Text = "1000";
                label62.Text = "27 E";

            }
            else
                {
                label44.Text = "27 B";
                label61.Text = "27 B";
                amount = amount + 2000;
                
                label67.Text = "2000";
                label62.Text = "27 B";

            }
            st9.Enabled = false;
            totalseats++;
            CheckSeats();
            st9.BackColor = Color.LimeGreen;
        }

            private void button39_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button38_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "29 E";
                label61.Text = "29 E";
                label62.Text = "29 E";

                amount = amount + 1000;

                label67.Text = "1000";
            }
            else
                {
                label44.Text = "29 B";
                label61.Text = "29 B";
                amount = amount + 2000;
                
                label67.Text = "2000";
                label62.Text = "29 B";

            }
            st10.Enabled = false;
            totalseats++;
            CheckSeats();
            st10.BackColor = Color.LimeGreen;
        }

            private void button37_Click(object sender, EventArgs e)
            {
            DisplayMessage();
        }

            private void button36_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "31 E";
                label61.Text = "31 E";
                amount = amount + 1000;

                label67.Text = "1000";
                label62.Text = "31 E";

            }
            else
                {
                label44.Text = "31 B";
                label61.Text = "31 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "31 B";

            }
            st11.Enabled = false;
            totalseats++;
            CheckSeats();
            st11.BackColor = Color.LimeGreen;
        }

            private void button35_Click(object sender, EventArgs e)
            {
            DisplayMessage();
            }

            private void button34_Click(object sender, EventArgs e)
            {
                if (label60.Text == "Economy")
                {
                label44.Text = "33 E";
                label61.Text = "33 E";
                amount = amount + 1000;

                label67.Text = "2000";
                label62.Text = "33 E";

            }
            else
                {
                label44.Text = "33 B";
                label61.Text = "33 B";
                amount = amount + 2000;

                label67.Text = "2000";
                label62.Text = "33 B";

            }
            st12.Enabled = false;
            totalseats++;
            CheckSeats();
            st12.BackColor = Color.LimeGreen;

        }

        private void button25_Click(object sender, EventArgs e)
            {
            DisplayMessage();
            }
        

        private void UpdatePage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void Ticketpage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }

        private void CancelPage_Click(object sender, EventArgs e)
        {
            downpanel.Size = downpanel.MinimumSize;
        }
        public void CheckSeats()
        {
            if (totalseats == numericUpDown2.Value)
            {
                tabControl1.SelectedTab = Payment;
            }
        }
        public void DisplayMessage()
        {
            MessageBox.Show("Enable to Select this Seat.\n    Due to Covid-19 ", "Seat Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DestinationBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string query = " SELECT FlightCode,Source,Destination,AirLine,FlightType FROM allFlights ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format(" Destination LIKE '%{0}%'", DestinationBox.Text);
            con.Close();
            

        }

        private void SourceBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
          
            string query = "SELECT FlightCode,Source,Destination,AirLine,FlightType,Date FROM allFlights ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Source LIKE '%{0}%'", SourceBox.Text, DestinationBox.Text);
            con.Close();


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label60.Text = "Business";
                int cost = 5000;
                amount = amount + cost;

            }
            else
            {
                label60.Text = "Economy";
                int cost = 3000;
                amount = amount + cost;

            }
        }
        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
           
           
        }

        public int randomGateNo()
        {
            Random ran = new Random();
            int num = ran.Next(1, 15);
            return num;
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {
            
            label65.Text = randomGateNo().ToString();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            update();        
        }
        
        private void button8_Click_1(object sender, EventArgs e)
        {
            string searchticket=textBox2.Text;
            search(searchticket);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string searchticket = textBox20.Text;
              Delete(searchticket);

        }



        public void Delete(string Ticket)
        {
            con.Open();
            string query = "DELETE FROM PassengerInfo where Ticket = '" + Ticket + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have canceled your Reservations  ");
        }

        public void update()
        {
            con.Open();

            string query = "UPDATE PassengerInfo SET Name = '" + textBox3.Text + "', Passport# = '" + textBox4.Text + "', CNIC ='" + textBox5.Text + "', Phone# = '" + textBox6.Text + "', Email = '" + textBox7.Text + "'Where Ticket = '" + textBox2.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been Update !");
        }
        public void search(string ticket)
        {

            try
            {

                con.Open();
                string query = "SELECT * FROM PassengerInfo where Ticket = '" + ticket + "'";

                SqlCommand sda = new SqlCommand(query, con);
                SqlDataReader dr;

                dr = sda.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    textBox3.Text = (dr["Name"].ToString());
                    textBox4.Text = (dr["Passport#"].ToString());
                    textBox5.Text = (dr["CNIC"].ToString());
                    textBox6.Text = (dr["Phone#"].ToString());
                    textBox7.Text = (dr["Email"].ToString());
                }
                else
                {
                    MessageBox.Show("DATA NOT FOUND!!");

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void addPassenger()
        {
            Validation vad = new Validation();
            con.Open();
            string query = "INSERT INTO PassengerInfo (Name,Passport#,CNIC,Phone#,Email,Ticket,Payment) VALUES ('" + NameBox.Text + "','" + PassBox.Text + "','" + CNICBox.Text + "','" + PhoneBox.Text + "','" + EmailBox.Text + "','" + "#A00" + vad.tickNum() + "','" + textBox26.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Data Sucessfully Added", "Passenger Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            con.Close();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            string query = " SELECT * FROM PassengerInfo ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(" Ticket LIKE '%{0}%'", textBox1.Text);
            con.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Source_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            Source.Text = SourceBox.Text;
            Dest.Text = DestinationBox.Text;
            Name.Text = NameBox.Text;
            Gate.Text = randomGateNo().ToString();
            label35.Text = SourceBox.Text;
            label36.Text = DestinationBox.Text;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label17.Text = " Flight Code    " + dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            label14.Text = " Date           " + dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            label18.Text = " Airline        " + dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            nextPage = true;
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            Passenger.Obj.addPassengerList();
            int size=Passenger.Obj.getPassengerList().Count - 1;


            using (SaveFileDialog df = new SaveFileDialog() { Filter = "PDF files|*.pdf", ValidateNames = true })
            {
                if (df.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                    try
                    {

                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 24, iTextSharp.text.Font.NORMAL);

                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(df.FileName, FileMode.Create));
                        doc.Open();


                        iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("logo.jpeg");
                        png.ScalePercent(20f);
                        png.Alignment = Element.ALIGN_CENTER;
                        doc.Add(png);



                        Paragraph p = new Paragraph(string.Format(" PARWAZ AIRLINES " + Environment.NewLine), font);
                        p.Alignment = Element.ALIGN_CENTER;
                        doc.Add(p);
                        iTextSharp.text.Font font1 = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                        Paragraph p1 = new Paragraph(string.Format(" Go Forth And Wander! " + Environment.NewLine), font1);
                        p1.Alignment = Element.ALIGN_CENTER;
                        doc.Add(p1);
                        iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
                        Paragraph p2 = new Paragraph(string.Format(Environment.NewLine +
                                                                   "  Ticket #        " + Passenger.Obj.getPassengerList().ElementAt(size).TicketNumber +Environment.NewLine +
                                                                   "  Form   :           "+ dataGridView2.SelectedRows[0].Cells[1].Value.ToString()+ Environment.NewLine +
                                                                   "  To     :              " + dataGridView2.SelectedRows[0].Cells[2].Value.ToString() + Environment.NewLine +
                                                                   "  Seat #                " + label62.Text + Environment.NewLine +
                                                                   "  Passport #           " + Passenger.Obj.getPassengerList().ElementAt(size).PassportNumber + Environment.NewLine +
                                                                   "  Flight Code          "+ dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + Environment.NewLine +
                                                                   "  Date   :                " + dataGridView2.SelectedRows[0].Cells[5].Value.ToString() +Environment.NewLine), font2);
                        p2.Alignment = Element.ALIGN_CENTER;
                        doc.Add(p2);

                        Paragraph p3 = new Paragraph(string.Format(Environment.NewLine +
                                                                   " Contact Us : Parwaz@gmail.com" + Environment.NewLine +
                                                                   " Phone # 03330605515" + Environment.NewLine), font2);
                        p3.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(p3);

                        LineSeparator line1 = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_LEFT, 5);
                        doc.Add(new Chunk(line1));

                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }

                }
            }
        }
    }
}

