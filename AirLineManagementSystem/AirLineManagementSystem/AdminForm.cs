﻿using System;
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
