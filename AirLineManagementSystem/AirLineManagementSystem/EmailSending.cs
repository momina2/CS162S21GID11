using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AirLineManagementSystem
{
    public partial class EmailSending : Form
    {
        public EmailSending()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("parwaazncooperation@gmail.com", "Parwaaz123");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("parwaazncooperation@gmail.com");
                msg.Subject = textBox2.Text;
                msg.Body = textBox3.Text;
                client.Send(msg);
                MessageBox.Show("Mail sent Successfully", "Mail Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR 404", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
