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

            // read asynchronously from a file

            //Goods items = JsonConvert.DeserializeObject<Goods>(File.ReadAllText(path));

            //// deserialize JSON directly from a file
            //using (StreamReader file = File.OpenText(path))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    Goods item2 = (Goods)serializer.Deserialize(file, typeof(Goods));
            //}

            //StreamReader reader = new StreamReader(path);
            //String stringout = reader.ReadToEnd();
            //reader.Close();
            //var settings = new JsonSerializerSettings();
            //settings.TypeNameHandling = TypeNameHandling.Objects;
            //Goods output = JsonConvert.DeserializeObject<Goods>(stringout, settings);


           
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string json = reader.ReadToEnd();
            //    dynamic files = JsonConvert.DeserializeObject(json);
            //}
            //Goods items = JsonConvert.DeserializeObject<Goods>(File.ReadAllText(path));

            //StreamReader streamReader = new StreamReader(path);
            //string json = streamReader.ReadToEnd();
            //List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(json);

            //items.AddRange(1, "Cosmostars", 44.0, "UAH", 12, "cerials");

            //foreach (Goods i in items)
            //{
            //    Console.WriteLine(i);
            //}

            //JsonConvert.Serialize(stream, obj);
            //stream.Close();

            //stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //Goods items = JsonConvert.DeserializeObject<Goods>(stream);

            //Console.WriteLine(items.id);
            //Console.WriteLine(items.name);

            //Console.ReadKey();


            //Goods deserializedProduct = JsonConvert.DeserializeObject<Goods>(path);


            //string SourceJson = File.ReadAllText(path);
            //var source = JsonConvert.DeserializeObject<List<Goods>>(SourceJson);


            //List<Goods> items = new List<Goods>();
            //items = JsonConvert.DeserializeObject<List<Goods>>(path);
            //foreach (Goods i in items)
            //{
            //    Console.WriteLine(i);
            //}


            //Goods rootObj = JsonConvert.DeserializeObject<Goods>(File.ReadAllText(path));
            //List<Goods> items = new List<Goods>();
            //items = JsonConvert.DeserializeObject<List<Goods>>(path);
            //Console.WriteLine(items(1));


            //List<Goods> items = new List<Goods>();
            //items = JsonConvert.DeserializeObject<List<Goods>>(path);
            //Console.WriteLine(items);


            //JObject item = new JObject();
            //Newtonsoft.Json.JsonConvert.DeserializeObject<Goods>(path);
            //string jsonFromFile
            //var reader = new StreamReader(path + "Source.json");

            //reader.ReadToEnd();
            //using (var reader = new StreamReader(path + "Source.json")
            //{
            //    jsonFromFile = reader.ReadToEnd();
            //}


            //Goods items = JsonConvert.DeserializeObject<Goods>(File.ReadAllText(path + "Source.json"));

            //Console.WriteLine(items);
            //JObject o1 = JObject.Parse(File.ReadAllText(path + "Source.json"));

            //// read JSON directly from a file
            //using (StreamReader file = File.OpenText(path + "Source.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}
        }
        public static List<Goods> LoadTemporaryObject()
        {
            List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(SourceController.sData);
            Console.WriteLine("a" + items);
            return items;
        }
    }
}
