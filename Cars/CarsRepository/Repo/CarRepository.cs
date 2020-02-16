using CarsRepository.Interface;
using CarsData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Repo
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext appDbContext;

        //EFDbContext context = new EFDbContext();
        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> GetAllCars()
        {
            return appDbContext.Cars/*.Include(c => c.Categories)*/;
        }

        public IEnumerable<Car> GetFavoriteCars => appDbContext.Cars.Where(p => p.IsFavorite).Include(c => c.Categories);

        public Car GetObjectCar(int CarId) => appDbContext.Cars.FirstOrDefault(p => p.CarId == CarId);

        public IEnumerable<Car> GetCarsCategory(int Id) => appDbContext.Cars.Where(x => x.CategoryId == Id);
        public IEnumerable<Car> GetCarsByCategory(int categoryId)
        {
            if(categoryId == -1)
            {
                return (GetAllCars());
            }
            else
            {
                return (GetCarsCategory(categoryId));
            }
    
        }
        
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
