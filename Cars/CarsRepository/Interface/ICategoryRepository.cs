using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
