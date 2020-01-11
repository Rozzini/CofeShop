using System;
using System.Collections.Generic;
using System.Text;

namespace CofeShop.Models
{
    class employee
    {
        
        public int employeeId { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public string designation { get; set; }

        public employee(int employeeId, string lastName, string firstName, string designation)
        {
            this.employeeId = employeeId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.designation = designation;
        }
    }
}
