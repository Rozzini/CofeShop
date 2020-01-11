using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class EmployeeController
    {

        public static void add()
        {

        }

        public static void remove()
        {

        }

        public static void view()
        {

        }
        public static void LoadJsonEmployee()
        {
            string path = Directory.GetCurrentDirectory();
            if (!File.Exists(path + "Employee.json"))
            {
                Console.WriteLine("\nFile doesnt exist: Creating new File\n");
                File.Create(path + "Employee.json");
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
            }
        }

    }
}
