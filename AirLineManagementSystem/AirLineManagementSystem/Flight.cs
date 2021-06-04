using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AirLineManagementSystem
{
    class Flight : Multiway
    {

        List<Flight> FlightInfoList = new List<Flight>();
        private static Flight obj = null;

        public static Flight Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Flight();
                }
                return obj;
            }
        }


        private string source;
        private string destination;
        private string flightCode;
        private string airlineName;
        private string flightType;
        private string date;
        private string timeTravel;
        private string luggage;
        private string layover;
        public string Layover
        {
            get { return layover; }
            set { layover = value; }
        }
        public string luggageAllowance
        {
            get { return luggage; }
            set { luggage = value; }

        }

        public string travel
        {
            get { return timeTravel; }
            set { timeTravel = value; }
        }
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

        public string timedate
        {
            get { return date; }
            set { date = value; }

        }
        SqlConnection con = new SqlConnection(Configuration.connection);

        public List<Flight> addFlightList()
        {
            FlightInfoList.Clear();
            Flight fgt;
            con.Open();
            string query = "SELECT * FROM allFights";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgt = new Flight();
                fgt.Source = dt.Rows[i]["Source"].ToString();
                fgt.Destination = dt.Rows[i]["Destination"].ToString();
                fgt.FlightCode= dt.Rows[i]["FlightCode"].ToString();
                fgt.AirlineName = dt.Rows[i]["Airline"].ToString();
                fgt.FlightType = dt.Rows[i]["FlightType"].ToString();
                fgt.timedate = dt.Rows[i]["Date"].ToString();
                fgt.travel = dt.Rows[i]["TimeTravel"].ToString();
                fgt.luggageAllowance = dt.Rows[i]["Luggage"].ToString();
                fgt.Layover = dt.Rows[i]["Layover"].ToString();



                // pass.Email = DateTime.Parse(dt.Rows[i]["ManufacturingDate"].ToString());
                // pass.ExpiryDate = DateTime.Parse(dt.Rows[i]["ExpiryDate"].ToString());

                FlightInfoList.Add(fgt);
            }
            con.Close();
            return FlightInfoList;
        }

       /* public List<Flight> getFlightCode()
        {
            Flight fgt;
            con.Open();
            string query = "SELECT * FROM allFights";
            SqlDataAdapter  = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<Flight> FlightInfoList = new List<Flight>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgt = new Flight();
                fgt.FlightCode = dt.Rows[i]["FlightCode"].ToString();
                FlightInfoList.Add(fgt);
            }

            return FlightInfoList;
        }*/
    }
}