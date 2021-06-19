using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AirLineManagementSystem
{
    class Validation
    {

        public bool ValidName(string name)
        {
            bool flag = false;
            char[] arr = name.ToCharArray();
            for(int i=0; i<name.Length;i++)
            {
                if ((arr[i] <= 'a' && arr[i] >= 'z') || (arr[i] <= 'A' && arr[i] >= 'Z') || (arr[i] == ' '))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public bool ValidPassPort(string passport)
        {
            bool flag = false;
            if (passport.Length == 9)
            {
               flag = true;
            }
            else
            {
                flag = false;
            }


            return flag;
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

        public bool isValidCNIC(string cnic)
        {
            /*bool flag = false;
            char[] c = cnic.ToCharArray();
            for (int i = 0; i <= 4; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (c[5] == '-')
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            for (int i = 6; i <= 12; i++)
            {
                if (c[i] >= '0' && c[i] <= '9')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (c[13] == '-')
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            if (c[14] >= '0' && c[14] <= '9')
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;*/
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(cnic);
            return valid;
        }

        public bool isValidEmail(string email)
        {
            bool flag = false;
            if (email.Contains("@"))
            {
                if (email.Contains(".com"))
                {
                    flag = true;
                }
            }
            else
            {
                flag = false;
            }
            return flag;
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
        public bool isValidPhoneNum(string phoneNum)
        {
            bool flag = false;
            char[] Phone = phoneNum.ToCharArray();
            if (phoneNum.Length == 11)
            {

                for (int i = 0; i < 11; i++)
                {
                    if (Phone[i] >= '0' || Phone[i] <= '9')
                    {
                        flag = true;
                    }
                }
            }
            return flag;
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
