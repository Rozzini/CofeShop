using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Interface
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();

        IEnumerable<Car> GetFavoriteCars();

        IEnumerable<Car> GetCarsByCategory(int categoryId);

        Car GetObjectCar(int CarId);

        void CreateCar(Car Cars);

        void SaveCar(Car Cars);

        void DeleteCar(int CarId);
    }
}
