using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            LoginForm lf = new LoginForm();
            lf.Hide();
        }

        private void Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Password.Checked)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
