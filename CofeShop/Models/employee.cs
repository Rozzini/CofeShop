using System;
using System.Collections.Generic;
using System.Text;

namespace CofeShop.Models
{
    class Employee
    {
        
        public int employeeId { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public string designation { get; set; }

        public Employee(int employeeId, string lastName, string firstName, string designation)
        {
            this.employeeId = employeeId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.designation = designation;
        }
    }
}
