using System;
using System.IO;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class SourceController
    {

        static string path = (Directory.GetCurrentDirectory() +"Source.json");

        

        public static void LoadJsonSource()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("\nFile doesnt exist: Creating new File\n");
                File.Create(path);
            }
            else
            {
                Console.WriteLine("\nFile exists\n");
            }
        }


    
    }
}
