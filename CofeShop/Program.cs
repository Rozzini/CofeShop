using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CofeShop.Models;
using CofeShop.Controllers;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CofeShop
{
    public class Program
    {
        //public static string path = (Directory.GetCurrentDirectory() + "Source.json");

        public static void Main(string[] args)
        {
            int choice = 2;

            var builder = new ConfigurationBuilder();
            
            builder.SetBasePath(Directory.GetCurrentDirectory());
            
            builder.AddJsonFile("appsettings.json");
            
            var config = builder.Build();
            
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
            do
            {
                Console.WriteLine("Type 1: to show DB;\n     2: add data to BD;\n     3: delete data from DB;\n     0: exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    
                    case 1:
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
                        break;
                        
                    case 2:
                        string name;
                        double price;
                        string currency;
                        uint quantity;
                        string category;
                        Console.WriteLine("Name : " + (name = Convert.ToString(Console.ReadLine())) + 
                                          "Price : " + (price = Convert.ToDouble(Console.ReadLine())) + 
                                          "Currency : " + (currency = Convert.ToString(Console.ReadLine())) + 
                                          "Quantity : " + (quantity = Convert.ToUInt32(Console.ReadLine())) +
                                          "Categpty : " + (category = Convert.ToString(Console.ReadLine()))
                                          );

                        using (ApplicationContext db = new ApplicationContext(options))
                        {
                            Good good = new Good { Name = name, Price = price, Currency = currency, Quantity = quantity, Category = category };
                            db.Goods.Add(good);
                            db.SaveChanges();
                        }
                        Console.WriteLine("input any button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
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
                        break;

                    case 0:
                        Console.WriteLine("Good night son\n");
                        Console.WriteLine("input any button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Incorrect data input\n");
                        Console.WriteLine("input any button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                
            } while (choice != 0);
        }
    }
}