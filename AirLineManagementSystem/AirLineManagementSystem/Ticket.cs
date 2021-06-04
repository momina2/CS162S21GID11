using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class Ticket
    {
        private string ticketNumber;
        private DateTime time;
        private string price;
        private int luggage;
        private string flightType;


        public string TicketNumber
        {
            get { return ticketNumber; }
            set {ticketNumber = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Luggage
        {
            get { return Luggage; }
            set { Luggage = value; }
        }
        public string FlightType
        {
            get { return flightType; }
            set { flightType = value; }
        }

    }
}
