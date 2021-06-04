using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        List<AirLine> Airlist = new List<AirLine>();
        SqlConnection con = new SqlConnection(Configuration.connection);

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
            get {

                return airlineCode; }
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
        public List<AirLine> AddAirLineList(AirLine obj)
        {
           Airlist.Clear();
            AirLine air;
            con.Open();
            string query = "SELECT * FROM  AirlineData";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 air = new AirLine();
               air.AirLineName = dt.Rows[i]["AirlineName"].ToString();
               air.AirLineCode = dt.Rows[i]["AirlineCode"].ToString();
                air.AirLineStatus = dt.Rows[i]["Status"].ToString();
                air.Description = dt.Rows[i]["Description"].ToString();
               


                Airlist.Add(air);
            }
            con.Close();
            return Airlist;
        }
        public  List<AirLine> DisplayFlight()
        {
            return Airlist;
        }
    }
}
