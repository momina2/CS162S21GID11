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



        SqlConnection con = new SqlConnection(Configuration.connection);
        FlightsFlying flightData=new FlightsFlying();
        TimeTravel travelTime = new TimeTravel();
        TextBox Midstop = new TextBox();

        private void FlightsUC_Load(object sender, EventArgs e)
        {
            ToViewFlights(); 
            comboBox1.DataSource = getAirLine();
            comboBox1.DisplayMember = "Airline";

            //Add buttons in the table dynamically 
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Delete";
            btn2.Width = 25;
            btn2.Name = "del";
            btn2.Text = "Delete";
            btn2.UseColumnTextForButtonValue = true;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.DefaultCellStyle.BackColor = Color.White;
            btn2.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns.Add(btn2);


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
                flightData.FlightType = "Domestic";

            }

        }

                   
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {

                //autocomplete dynamically 
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

            flightData.Source=SourceBox.Text;
            flightData.Destination = DestinationBox.Text;
            flightData.FlightTime = dateTimePicker1.Value;

            


            flightData.MidWayStop = Midstop.Text;
            if(flightData.MidWayStop==null)
            {
                flightData.MidWayStop = "No Layover";
            }
          

           

            flightData.FlightLuggage = textBox4.Text;
            flightData.AirlineName = comboBox1.SelectedItem.ToString();
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text.ToLower().ToString();

            FlightsFlying.Obj.AddFlightList(flightData);
            Validation v = new Validation();


            con.Open();
            string query = "INSERT INTO allFlights (FlightCode,Source,Destination,AirLine,FlightType,TimeTravel,Date,Luggage,LayOver) VALUES ('" + "#" + v.alpha() +v.Airline_Code_Generator() + "','" + SourceBox.Text + "','" + DestinationBox.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + value + "','" + travelTime.FlightTime(textBox3.Text) + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + flightData.MidWayStop + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
           
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Flight has been added ", "Flights ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            //to View Data in Table
            ToViewFlights();
        }
        
      
        //add data in table 
        public void ToViewFlights()
        {

            con.Open();
            string query = "SELECT FlightCode,Source,Destination,AirLine,FlightType,Date FROM allFlights";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       

        

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            SourceBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DestinationBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 1)
            {

                string value = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                con.Open();
                string query = "DELETE FROM allFlights where FlightCode = '" + value + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
               
                ToViewFlights();

            }
        }
        //From DB to list
        //and in combobox
        public List<String> getAirLine()
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select AirlineName from AirlineData";

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            List<string> list = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                String airlinelist;
               airlinelist = (row["AirlineName"]).ToString();
                list.Add(airlinelist);
            }

            con.Close();
            return list;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
