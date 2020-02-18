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
        
        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> GetAllCars()
        {
            return appDbContext.Cars;
        }

        public IEnumerable<Car> GetFavoriteCars()
        {
            return appDbContext.Cars.Where(p => p.IsFavorite).Include(c => c.Categories);
        }

        public Car GetObjectCar(int CarId)
        {
            return appDbContext.Cars.FirstOrDefault(p => p.CarId == CarId);
        }

        public IEnumerable<Car> GetCarsCategory(int Id)
        {
            return appDbContext.Cars.Where(x => x.CategoryId == Id);
        }

        public IEnumerable<Car> GetCarsByCategory(int categoryId)
        {                     
                return (GetCarsCategory(categoryId));             
        }

        public void CreateCar(Car Cars)
        {
           appDbContext.Cars.Add(Cars);                           
           appDbContext.SaveChanges();
        }

        public void SaveCar(Car Cars)
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
            appDbContext.SaveChanges();
        }

        public void DeleteCar(int CarId)
        {
            Car dbEntry = appDbContext.Cars.Find(CarId);
            if (dbEntry != null)
            {
                appDbContext.Cars.Remove(dbEntry);
                appDbContext.SaveChanges();
            }            
        }        
    }


    
}
