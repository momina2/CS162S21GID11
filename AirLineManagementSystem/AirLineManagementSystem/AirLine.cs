using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class AirLine
    {
        private string airlineCode;
        private string airlineName;
        private string description;
        private string airlineStatus;
        private static AirLine obj = null;
        SortedSet<AirLine> AirlineSet = new SortedSet<AirLine>();

        public static AirLine Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new AirLine();
                }
                return obj;
            }
        }
        public string AirLineCode
        {
            get { return airlineCode; }
            set { airlineCode = value; }
        }

        public string AirLineName
        {
            get { return airlineName; }
            set { airlineName = value; }
        }

        public string AirLineStatus
        {
            get { return airlineStatus; }
            set { airlineStatus = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public void AddAirLineList(AirLine obj)
        {
            AirlineSet.Add(obj);
        }
        public SortedSet<AirLine> DisplayFlight()
        {
            return AirlineSet;
        }
    }
}
