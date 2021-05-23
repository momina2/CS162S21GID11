﻿using System;
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

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewPage_Click(object sender, EventArgs e)
        {

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
    }
}
