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
            if (!name.Contains("[A-Z]") || !name.Contains("[a-z]"))
            {
                flag = true;



            }
            else
            {
                flag = false;
                MessageBox.Show("Invalid Name", "RE-CHECK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return flag;

        }

        public bool ValidPassPort(string passport)
        {
            bool flag = false;
            Regex checking = new Regex(@"^[0-9]{9}$");
            if (checking.IsMatch(passport))
            {
                flag = true;
            }
            else
            {
                MessageBox.Show("Invalid Passport Number", "RE-CHECK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            return flag;
        }
        public int ValidTicket(int ticket)
        {
            if ((ticket >= 'A' || ticket <= 'Z') || (ticket >= 'a' || ticket <= 'z'))
            {
                MessageBox.Show("InValid Name");
            }
            else
            {
                MessageBox.Show("Valid Name");
            }

            return ticket;
        }

        public bool isValidCNIC(string cnic)
        {
           
            Regex checking = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool flag = false;
            if (checking.IsMatch(cnic))
                flag= true;
            else
            {
                MessageBox.Show("Invalid CNIC Number", "RE-CHECK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                flag = false;
            }
            return flag;
        }
                
                

        public bool isValidEmail(string email)
        {
            bool flag = false;
            if (email.Contains("@") && email.Contains(".com"))
            {
               
                    flag = true;
            }
            else
            {
                MessageBox.Show("Invalid Email","RE-CHECK",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return  false;

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
            
            Regex checking = new Regex(@"^[0-9]{11}$");
            bool flag = false;
            if (checking.IsMatch(phoneNum))
            {
                flag = true;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number");
                flag = false;
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
