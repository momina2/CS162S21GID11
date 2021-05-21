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
            this.cancelpanel.Location = this.cancelpanel.Location;
            this.cancelpanel.Show();
            this.cancelpanel.BringToFront();

            this.Homepanel.SendToBack();
            this.Homepanel.Hide();
            this.Homepanel.SendToBack();
            this.Homepanel.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Width = button1.Width;
            sidepanel.Top = button1.Bottom;
            sidepanel.Location = button1.Location;
            this.Homepanel.Location = this.Homepanel.Location;
            this.Homepanel.Show();
            this.Homepanel.BringToFront();

            this.cancelpanel.SendToBack();
            this.cancelpanel.Hide();
            this.cancelpanel.SendToBack();
            this.cancelpanel.Hide();
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

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
                downpanel.Size = downpanel.MaximumSize;
            this.downpanel.BringToFront();


        }
    }
}
