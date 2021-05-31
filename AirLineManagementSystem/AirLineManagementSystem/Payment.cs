using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    abstract class Payment
    {
        private double totalTransaction;

        public double TotalTransaction
        {
            get { return totalTransaction; }
            set { totalTransaction = value; }
        }

        public abstract double TransactionAmount();
    }
}
