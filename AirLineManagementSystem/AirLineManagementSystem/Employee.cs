using System;
using System.Collections.Generic;
using System.Text;

namespace AirLineManagementSystem
{
    class Employee
    {

        List<Employee> empList = new List<Employee>();
        private static Employee obj = null;
        public static Employee Obj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Employee();
                }
                return obj;
            }
        }

        private string name;
        private string phoneNumber;
        private string cnic;
        private string employeeId;

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
        public string EmployeeId
        { 
            get { return employeeId; }
            set { employeeId = value; }
        }
        public void AddEmployeeList(Employee obj)
        {
            empList.Add(obj);
        }
        public List<Employee> DisplayFlight()
        {
            return empList;
        }
    }
}
