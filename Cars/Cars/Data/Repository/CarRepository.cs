using Cars.Data.Interface;
using Cars.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Repository
{
    public class CarRepository : ICar
    {
        private readonly AppDbContext appDbContext;

        //EFDbContext context = new EFDbContext();
        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> Cars => appDbContext.Cars.Include(c => c.Categories);

        public IEnumerable<Car> GetFavoriteCars => appDbContext.Cars.Where(p => p.IsFavorite).Include(c => c.Categories);

        public Car GetObjectCar(int CarId) => appDbContext.Cars.FirstOrDefault(p => p.CarId == CarId);

        public void SaveCar(Car Cars)
        {
            if (Cars.CarId == 0)
                appDbContext.Cars.Add(Cars);
            
            else
            {
                Car dbEntry = appDbContext.Cars.Find(Cars.CarId);
                if (dbEntry != null)
                {
                    dbEntry.Name = Cars.Name;
                    dbEntry.ShortDescription = Cars.ShortDescription;
                    dbEntry.LongDescription = Cars.LongDescription;
                    dbEntry.Image = Cars.Image;
                    dbEntry.Price = Cars.Price;
                    dbEntry.IsFavorite = Cars.IsFavorite;
                    dbEntry.Available = Cars.Available;
                    dbEntry.CategoryId = Cars.CategoryId;
                }
            }
            appDbContext.SaveChanges();
        }

        public Car DeleteCar(int CarId)
        {
            Car dbEntry = appDbContext.Cars.Find(CarId);
            if (dbEntry != null)
            {
                appDbContext.Cars.Remove(dbEntry);
                appDbContext.SaveChanges();
            }
            return dbEntry;
        }
    }


    
}
