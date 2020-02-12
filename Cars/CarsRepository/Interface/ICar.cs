using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Interface
{
    public interface ICar
    {
        IEnumerable<Car> GetAllCars { get; }

        IEnumerable<Car> GetFavoriteCars { get; }

        IEnumerable<Car> GetCarsByCategory(int categoryId);
        Car GetObjectCar(int CarId);

        void SaveCar(Car Cars);

        Car DeleteCar(int CarId);
    }
}
