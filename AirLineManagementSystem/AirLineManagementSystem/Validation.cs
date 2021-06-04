using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    class Validation
    {

        public string ValidName(string name)
        {
            if (Regex.Match(name, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                bool flag = true;
            }
            else
            {
                bool flag = false;

            }
            return name;
        }

        public int ValidTicket(int ticket)
        {
            if ((ticket >= 'A' || ticket <= 'Z') || (ticket >= 'a' || ticket <= 'z'))
            {
                Console.WriteLine("InValid Name");
            }
            else
            {
                Console.WriteLine("Valid Name");
            }

            return ticket;
        }

        public string isValidCNIC(string cnic)
        {
            bool flag = false;
            char[] c = cnic.ToCharArray();
            for (int i = 0; i <= 4; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
            }
            if (c[5] == '-')
            {
                flag = true;
            }
            for (int i = 6; i <= 12; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
            }
            if (c[13] == '-')
            {
                flag = true;
            }
            if (c[14] >= '0' && c[14] <= '9')
            {
                flag = true;
            }
            return cnic;
        }

        public string isValidEmail(string email)
        {
            bool flag = false;
            if (email.Contains("@"))
            {
                Console.WriteLine("Email contains @");
            }
            else
            {
                Console.WriteLine("inValid");

            }
            if (email.Contains("[0123456789]"))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("inValid Name");

            }

            return email;
        }

        //Random number for Flightcode
        public char alpha()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('A', 'Z');
            return randomChar;
        }

        //Random alphabet for Flightcode
        public int Airline_Code_Generator()
        {
            Random ran1 = new Random();
            int num = ran1.Next(100, 500);
            return num;
        }
        //Random Ticket Number
        public int tickNum()
        {

            Random ran1 = new Random();
            int num = ran1.Next(1000, 2000);
            return num;

        }
        public string isValidPhoneNum(string phoneNum)
        {
            bool flag = false;
            char[] Phone = phoneNum.ToCharArray();
            if (phoneNum.Length > 11 || phoneNum.Length < 11)
            {
                MessageBox.Show("Re-check the Phone Number Length");
            }

            for (int i = 0; i < 11; i++)
            {
                if (Phone[i] >= '0' || Phone[i] <= '9')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            if (false)
            {
                MessageBox.Show("Invalid Phone#");
            }
            return phoneNum;
        }

        //EMPLOYEE ID RANDOMLY
        public int randomID()
        {
            Random ran = new Random();
            int num = ran.Next(100, 500);
            return num;

        }
    }

   
}
