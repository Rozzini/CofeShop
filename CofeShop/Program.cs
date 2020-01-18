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
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (ApplicationContext db = new ApplicationContext(options))
            {
                var goods = db.Goods.ToList();
                foreach (Good g in goods)
                {
                    Console.WriteLine($"{g.Id}.{g.Name} - {g.Price}");
                }
            }
            Console.Read();
        }
    }
}