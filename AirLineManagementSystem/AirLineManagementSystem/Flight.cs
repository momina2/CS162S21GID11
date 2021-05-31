using System;
using System.Collections.Generic;
using System.Text;


namespace AirLineManagementSystem
{
    class Flight
    {

        private string source;
        private string destination;
        private string flightCode;
        private string airlineName;
        private string flightType;





        public string Source
        {
            get { return source; }
            set { source = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string FlightCode
        {
            get { return flightCode; }
            set { flightCode = value; }
        }
        public string AirlineName
        {
            get { return airlineName; }
            set { airlineName = value; }
        }
        public string FlightType
        {
            get { return flightType; }
            set { flightType = value; }
        }


    }
}
