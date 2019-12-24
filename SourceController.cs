using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    class SourceController
    {
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


        public static void LoadJson()
        {
            string path = "C:\\Users\\rozzi\\source\\repos\\CofeShop\\CofeShop\\Models\\Source.json";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public static List<Goods> LoadTemporaryObject()
        {
            List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(SourceController.sData);
            Console.WriteLine("a" + items);
            return items;
        }
    }
}
