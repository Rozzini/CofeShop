using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsServices.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public IEnumerable<Car> GetCarsByCategory { get; set; }
        public IEnumerable<Category> GetAllCategories { get; set; }

        public string CurrentCategory { get; set; }
    }
}
