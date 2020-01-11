using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
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


        public static void ReadJsonSource()
        {
            StreamReader reader = new StreamReader(path);
            String stringout = reader.ReadToEnd();
            reader.Close();
            var settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;
            Goods output = JsonConvert.DeserializeObject<Goods>(stringout, settings);

            string json = File.ReadAllText(path);
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                Goods items = (Goods)serializer.Deserialize(file, typeof(Goods));
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
