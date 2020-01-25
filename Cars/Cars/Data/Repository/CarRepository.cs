using Cars.Data.Interface;
using Cars.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> Cars => appDbContext.Cars.Include(c => c.Categories);

        public IEnumerable<Car> GetFavCars => appDbContext.Cars.Where(p => p.IsFavorite).Include(c => c.Categories);

        public Car GetObjectCar(int CarId) => appDbContext.Cars.FirstOrDefault(p => p.CarId == CarId);

    }
}
