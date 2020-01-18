using System;
using System.IO;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class DeliverersController
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

        public static void LoadJsonDeliverers()
        {
            string path = Directory.GetCurrentDirectory();
            if (!File.Exists(path + "Deliverers.json"))
            {
                Console.WriteLine("\nFile doesnt exist: Creating new File\n");
                File.Create(path + "Deliverers.json");
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
            }
        }
    }
}
