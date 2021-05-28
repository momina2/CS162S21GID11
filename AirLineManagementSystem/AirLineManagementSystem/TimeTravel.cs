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
    }
}
