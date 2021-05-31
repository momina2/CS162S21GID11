using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
   abstract class FlightSeats
    {
        private double flightSeats;

        public double FlightSeat
        {
            get { return flightSeats; }
            set { flightSeats = value; }
        }

        public abstract double EmptyFlight();
    }
}
