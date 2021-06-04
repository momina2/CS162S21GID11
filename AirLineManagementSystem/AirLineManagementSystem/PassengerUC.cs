using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class PassengerUC : UserControl
    {
        public PassengerUC()
        {
            InitializeComponent();
        }
        #region Properties
        private string name;
        private string passnumbernumber;
        private string amount;
        private string  ticketnumber;
        [Category("Custom Props")]
        public string Name1
        {
            get { return name; }
            set { name = value; namel.Text = value; }
        }
        [Category("Custom Props")]
        public string TicketNumber
        {
            get { return ticketnumber; }
            set { ticketnumber = value; ticketl.Text = value; }
        }
        [Category("Custom Props")]
        public string PassNumber
        {
            get { return passnumbernumber; }
            set { passnumbernumber = value; passnumberl.Text = value; }
        }
        [Category("Custom Props")]
        public string Amount
        {
            get { return amount; }
            set { amount= value; amountl.Text = value; }
        }

        #endregion

        private void ticketl_Click(object sender, EventArgs e)
        {

        }

        private void PassengerUC_Load(object sender, EventArgs e)
        {

        }
    }
}
