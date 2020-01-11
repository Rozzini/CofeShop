using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CofeShop.Models;
using System.Collections.Generic;

namespace CofeShop.Controllers
{
    public class HomeController
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
             
        public static List<Goods> LoadTemporaryObject()
        {
            List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(HomeController.sData);
            return items;
        }                        
    }
}
