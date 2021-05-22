using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    public partial class TransactionUC : UserControl
    {
        public TransactionUC()
        {
            InitializeComponent();
        }
        private string amount;
        private string name;
        [Category("Custom Props")]
        public string Name
        {
            get { return name; }
            set { name = value; passengernamel.Text = value; }
        }
        [Category("Custom Props")]
        public string Amount
        {
            get { return amount; }
            set { amount = value; paymentl.Text = value; }
        }
    }
}
