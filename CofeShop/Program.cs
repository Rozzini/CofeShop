using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using CofeShop.Models;
using CofeShop.Controllers;
using System.Collections.Generic;

namespace CofeShop
{
    class Program
    {
        static string path = (Directory.GetCurrentDirectory() + "Source.json");

        static void Main(string[] args)
        {
            
            Console.WriteLine(Directory.GetCurrentDirectory());
            SourceController.LoadJsonSource();
            SourceController.ReadJsonSource();
           //SourceController.ReadJsonSource();
           //List <Goods> items = Goods.ReadFromSource(path + "\\Models\\Source.json");
           //Console.WriteLine(items.Count);
        }

        
    }
}
