using CofeShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CofeShop.Controllers
{
    public class GoodsController
    {
        private static DbContextOptions<ApplicationContext> options;

        private dynamic CreateOptions()
        {
            var builder = new ConfigurationBuilder();
            
            builder.SetBasePath(Directory.GetCurrentDirectory());
            
            builder.AddJsonFile("appsettings.json");
            
            var config = builder.Build();
            
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
            return options;
        }
            
        public void Add()
        {
            options = CreateOptions();
            string name;
            double price;
            string currency;
            uint quantity;
            string category;
            Console.WriteLine("Name : ");     name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Price : ");    price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Currency : "); currency = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quantity : "); quantity = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Categpty : "); category = Convert.ToString(Console.ReadLine());
                              

            using (ApplicationContext db = new ApplicationContext(options))
            {
                Good good = new Good { Name = name, Price = price, Currency = currency, Quantity = quantity, Category = category };
                db.Goods.Add(good);
                db.SaveChanges();
            }
            Console.WriteLine("input any button to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public void Remove()
        {
            options = CreateOptions();
            int id;
            Console.WriteLine("input id: ");
            id = Convert.ToInt32(Console.ReadLine());
            using (ApplicationContext db = new ApplicationContext(options))
            {
                Good good = new Good { Id = id };
                db.Goods.Remove(good);
                db.SaveChanges();
            }
            Console.WriteLine("input any button to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public void View()
        {
            options = CreateOptions();
            using (ApplicationContext db = new ApplicationContext(options))
            {
                var goods = db.Goods.ToList();
                foreach (Good g in goods)
                {
                    Console.WriteLine($"{g.Id}.{g.Name} - {g.Price} - {g.Currency} - {g.Quantity} - {g.Category}.");
                }
            }
            Console.WriteLine("input any button to continue");
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
