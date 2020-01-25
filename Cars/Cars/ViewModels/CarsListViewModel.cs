using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}
 