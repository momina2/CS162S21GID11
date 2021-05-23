using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            CPB.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            CPB.Value += 1;
            CPB.Text = CPB.Value.ToString() + "%";
            if (CPB.Value == 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                AdminForm af = new AdminForm();

                af.Visible = true;
                af.BringToFront();
            }
        }

        private void CPB_Click(object sender, EventArgs e)
        {

        }
    }
}
