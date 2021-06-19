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
                MailMessage msg = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("parwaazncooperation@gmail.com", "Parwaaz123");
                
                 msg.Attachments.Add(new Attachment(textBox4.Text.ToString()));
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("parwaazncooperation@gmail.com");
                msg.Subject = "Parwaz Air Lines ";
                msg.Body = "Have a safe flight with us :)";
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Select File";
            od.Filter = "All files(*.*)|*.*";
            od.ShowDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                string path = od.FileName.ToString();
                textBox4.Text = path;
            }
        }

        private void EmailSending_Load(object sender, EventArgs e)
        {

        }
    }
}
