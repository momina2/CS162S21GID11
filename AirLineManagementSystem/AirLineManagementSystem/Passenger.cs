using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AirLineManagementSystem
{
    class Passenger : Ticket
    {
        SqlConnection con = new SqlConnection(Configuration.connection);
        List<Passenger> passengerList= new List<Passenger>();

        private static Passenger obj = null;
       

        public static Passenger Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Passenger();
                }
                return obj;
            }
        }

        private string name;
        private string phoneNumber;
        private string cnic;
        private string email;
        private int numberOfTickets;
        private string nationality ;
        private string passportNumber;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string PhoneNumber
        { 
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int NumberOFTickets
        {
            get { return numberOfTickets; }
            set {numberOfTickets = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set {nationality = value; }
        }
        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }
        public List<Passenger> addPassengerList()
        {
            passengerList.Clear();
            Passenger pass;
            con.Open();
            string query = "SELECT * FROM PassengerInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pass = new Passenger();
                pass.Name = dt.Rows[i]["Name"].ToString();
                pass.PassportNumber = dt.Rows[i]["Passport#"].ToString();
                pass.CNIC = dt.Rows[i]["CNIC"].ToString();
                pass.PhoneNumber =dt.Rows[i]["Phone#"].ToString();
                pass.TicketNumber= dt.Rows[i]["Ticket"].ToString();
                pass.Email = dt.Rows[i]["Email"].ToString();
                pass.Price = dt.Rows[i]["Payment"].ToString();

               

                passengerList.Add(pass);
            }
            con.Close();
            return passengerList;
        }
        public List<Passenger> getPassengerList()
        {
            return passengerList;
        }

    }
}
