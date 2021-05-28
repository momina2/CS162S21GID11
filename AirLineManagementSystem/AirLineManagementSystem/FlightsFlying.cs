using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class FlightsFlying
    {
        private string flightLuggage;
        private DateTime flightTime;

        public string FlightLuggage
        {
            get { return flightLuggage; }
            set { flightLuggage = value; }
        }
        public DateTime FlightTime
        {
            get { return flightTime; }
            set { flightTime = value; }
        }


    }
}
