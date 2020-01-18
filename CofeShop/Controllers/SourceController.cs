using System;
using System.IO;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class SourceController
    {

        static string path = (Directory.GetCurrentDirectory() +"Source.json");

        static string sData = @"[
  {
    'id': 1,
    'name': 'Cosmostars',
    'price': 44.0,
    'curency': 'UAH',
    'quantity': 12,
    'category': 'cerials'
  },
  {
    'id': 2,
    'name': 'Nesquick',
    'price': 45,
    'curency': 'UAH',
    'quantity': 8,
    'category': 'cerials'
  }
]
";


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
