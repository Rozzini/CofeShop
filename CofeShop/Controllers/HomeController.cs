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

       
        //public static void LoadJson()
        //{
        //    string path = "C:\\Users\\rozzi\\source\\repos\\CofeShop\\CofeShop\\Models\\Source.json";
        //    if (!File.Exists(path))
        //    {
        //        File.Create(path);
        //    }
        //}

        public static List<Goods> LoadTemporaryObject()
        {
            List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(HomeController.sData);
            return items;
        }


        
        
        /*public string Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        */
    }
}
