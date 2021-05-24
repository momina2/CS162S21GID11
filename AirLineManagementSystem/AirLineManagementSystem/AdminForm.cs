using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (Subpanel.Size == Subpanel.MaximumSize)
            {
                Subpanel.Size = Subpanel.MinimumSize;
            }
            else
               Subpanel.Size = Subpanel.MaximumSize;
             FlightsUC fuc = new FlightsUC();
           basepanel.Controls.Add(fuc);
            basepanel.Controls["FlightsUC"].BringToFront();




        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Subpanel.Size = Subpanel.MinimumSize;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeUC EUC = new EmployeeUC();
            basepanel.Controls.Add(EUC);
            basepanel.Controls["EmployeeUC"].BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAirline AL = new AddAirline();
            basepanel.Controls.Add(AL);
            basepanel.Controls["AddAirline"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        

            tabControl1.SelectedTab = TransactionPage;
            tabControl1.BringToFront();
            AddItemTransaction();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PassengerForm passenger = new PassengerForm();
            passenger.Show();
            this.Visible=false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RestoreSeats rs = new RestoreSeats();
            rs.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DelayUC df = new DelayUC();
            basepanel.Controls.Add(df);
            basepanel.Controls["DelayUC"].BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PassengerPage;
            tabControl1.BringToFront();
            AddItemPassenger();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab =HomePage;
            tabControl1.BringToFront();

        }

        private void passengerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemPassenger()
        {
            PassengerUC[] uc1 = new PassengerUC[6];

            for (int i = 0; i < 6; i++)
            {
                uc1[i] = new PassengerUC();
                uc1[i].Name1 = "KHADIJA DAR";
                uc1[i].PassNumber = "1" + i;
                uc1[i].TicketNumber = "#1092" + i;
                uc1[i].Amount = "107" +i+" Rs.";

                flowLayoutPanel2.Controls.Add(uc1[i]);


            }

        }

        private void AddItemTransaction()
        {
            TransactionUC[] uc1 = new TransactionUC[6];

            for (int i = 0; i < 6; i++)
            {
                uc1[i] = new TransactionUC();
                uc1[i].Name = "KHADIJA DAR";
                uc1[i].Amount = "1078" + i + " Rs.";

                flowLayoutPanel3.Controls.Add(uc1[i]);


            }

        }
    }
}
