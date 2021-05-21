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
            if (Subpanel.Size == Subpanel.MinimumSize)
            {
                Subpanel.Size = Subpanel.MaximumSize;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Subpanel.Size == Subpanel.MaximumSize)
            {
                Subpanel.Size = Subpanel.MinimumSize;
            }
            else
                Subpanel.Size = Subpanel.MaximumSize;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Subpanel.Size = Subpanel.MinimumSize;
        }
    }
}
