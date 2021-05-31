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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
