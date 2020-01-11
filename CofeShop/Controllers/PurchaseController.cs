using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class PurchaseController
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

        public static void LoadJsonPurchase()
        {
            string path = Directory.GetCurrentDirectory();
            if (!File.Exists(path + "Purchase.json"))
            {
                Console.WriteLine("\nFile doesnt exist: Creating new File\n");
                File.Create(path + "Purchase.json");
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
            }
        }
    }
}
