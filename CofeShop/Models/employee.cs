using System;
using System.Collections.Generic;
using System.Text;

namespace CofeShop.Models
{
    class Employee
    {
        
        public int EmployeeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Designation { get; set; }

        public Employee(int EmployeeId, string LastName, string FirstName, string Designation)
        {
            this.EmployeeId = EmployeeId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Designation = Designation;
        }
    }
}
