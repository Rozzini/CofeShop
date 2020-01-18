using System;
using System.IO;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class EmployeeController
    {

        public static void Add()
        {

        }

        public static void Remove()
        {

        }

        public static void View()
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
