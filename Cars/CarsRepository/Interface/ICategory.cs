using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
