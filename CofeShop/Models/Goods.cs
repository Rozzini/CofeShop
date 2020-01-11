using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace CofeShop.Models
{
    public class Goods
    {
        public int id { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public string curency { get; set; }

        public uint quantity { get; set; }

        public string category { get; set; }

        public Goods(int id, string name, double price, string curency, uint quantity, string category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.curency = curency;
            this.quantity = quantity;
            this.category = category;
        }
        public override string ToString()
        {
            return "id: " + id + " name: " + name + " price: " + price + " curency: " + curency + " quantity: " + quantity + " category: " + category;
        }

       

        public static List<Goods> ReadFromSource(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string json = streamReader.ReadToEnd();
            List<Goods> items = JsonConvert.DeserializeObject<List<Goods>>(json);
            return items;
        }
    }
}
