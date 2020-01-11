using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace CofeShop.Models
{
    public class Goods
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Currency { get; set; }

        public uint Quantity { get; set; }

        public string Category { get; set; }

        public Goods(int Id, string Name, double Price, string Currency, uint Quantity, string Category)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Currency = Currency;
            this.Quantity = Quantity;
            this.Category = Category;
        }
        public override string ToString()
        {
            return "id: " + Id + " name: " + Name + " price: " + Price + " curency: " + Currency + " quantity: " + Quantity + " category: " + Category;
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