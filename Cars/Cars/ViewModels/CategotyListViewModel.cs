using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.ViewModels
{
    public class CategotyListViewModel
    {
        public IEnumerable<Car> CatCar { get; set; }
    }
}
