using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AirLineManagementSystem
{
    class Flight
    {
        private bool ValidName(string name)
        {
            if (Regex.Match(name, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("InValid Name");


            }
            return false;
        }
        
        private bool IsValidFlightNo()
        {
            return false;
        }

        private bool ValidTicket(int ticket)
        {
            if((ticket >= 'A' || ticket <= 'Z') || (ticket >= 'a' || ticket <= 'z'))
            {
                Console.WriteLine("InValid Name");
            }
            else
            {
                Console.WriteLine("Valid Name");
            }
            
            return false;
        }

        private bool isValidCNIC(string cnic)
        {
            bool flag = false;
            char[] c = cnic.ToCharArray();
            for(int i=0; i<=4; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
            }
            if(c[5] == '-')
            {
                flag = true;
            }
            for(int i = 6; i<=12; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
            }
            if(c[13] == '-')
            {
                flag = true;
            }
            if(c[14] >= '0' && c[14] <= '9')
            {
                flag = true;
            }
            return false;
        }

        private bool isValidEmail(string email)
        {
            bool flag = false;
            if(email.Contains("@"))
            {
                Console.WriteLine("Email contains @");
            }
            else
            {
                Console.WriteLine("inValid");

            }
            if(email.Contains("[0123456789]"))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("inValid Name");

            }

            return false;
        }

        private bool IsValidPhone()
        {
            return false;
        }
    }
}
