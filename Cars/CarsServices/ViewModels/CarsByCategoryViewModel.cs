using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsServices.ViewModels
{
    public class CarsByCategoryViewModel
    {
        public int  GetCategoryId  { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
