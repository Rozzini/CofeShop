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
        

        public static void Main(string[] args)
        {
            int choice = 2;
           

            GoodsController g = new GoodsController();

            do
            {
                Console.WriteLine("Type 1: to show DB;\n     2: add data to BD;\n     3: delete data from DB;\n     0: exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    
                    case 1:
                        g.View();                       
                        break;
                        
                    case 2:
                        g.Add();                       
                        break;

                    case 3:
                        g.Remove();                      
                        break;

                    case 0:
                        Console.WriteLine("Good night son\n");
                        Console.WriteLine("input any button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Incorrect data input, try again\n");
                        Console.WriteLine("input any button to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                
            } while (choice != 0);
        }
    }
}