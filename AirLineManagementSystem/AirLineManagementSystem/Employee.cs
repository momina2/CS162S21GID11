using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class Employee
    {

        private string name;
        private int phoneNumber;
        private string cnic;
        private string employeeId;

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
        public string EmployeeId
        { 
            get { return employeeId; }
            set { employeeId = value; }
        }
    }
}
