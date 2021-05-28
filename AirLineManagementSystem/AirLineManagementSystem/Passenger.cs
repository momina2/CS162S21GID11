using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class Passenger
    {
        private string name;
        private int phoneNumber;
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
        public int PhoneNumber
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

    }
}
