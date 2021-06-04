using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class TimeTravel
    {

        private double totaldistance;
        private double time;

        public double TotalDistance
        {
            get { return totaldistance; }
            set { totaldistance = value; }
        }

        public double Time
        {
            get { return time; }
            set { time = value; }
        }

        public String FlightTime (String distance )
        {

            int Time = (int)(double.Parse(distance) / 926);

            return Time + "Hours";
        }
    }
}
