using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class DelayUC : UserControl
    {
        public DelayUC()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now > dateTimePicker1.Value)
            {
                MessageBox.Show("Invalid Date !", "Select Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
