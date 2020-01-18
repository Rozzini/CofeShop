using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CofeShop.Models
{
    public class Good
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Currency { get; set; }

        public uint Quantity { get; set; }

        public string Category { get; set; }

        //public Good(int Id, string Name, double Price, string Currency, uint Quantity, string Category)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Price = Price;
        //    this.Currency = Currency;
        //    this.Quantity = Quantity;
        //    this.Category = Category;
        //}
        public override string ToString()
        {
            return "id: " + Id + " name: " + Name + " price: " + Price + " curency: " + Currency + " quantity: " + Quantity + " category: " + Category;
        }

       

       
    }
}