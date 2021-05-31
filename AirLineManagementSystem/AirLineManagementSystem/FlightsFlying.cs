using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class FlightsFlying : Flight
    {
  
        
        public FlightsFlying()
        {
            TimeTravel timeTravel = new TimeTravel();
           
        }
        private static FlightsFlying obj = null;
        List<FlightsFlying> flightList = new List<FlightsFlying>();
        


        public static FlightsFlying Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new FlightsFlying();
                }
                return obj;
            }
        }
        private string flightLuggage;
        private DateTime flightTime;
        public double distanceTime;

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


        public void AddFlightList(FlightsFlying obj)
        {
            flightList.Add(obj);
        }
        public List<FlightsFlying> DisplayFlight()
        {
            return flightList;
        }


    }
}
