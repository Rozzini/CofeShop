using Cars.Data.Interface;
using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Mock
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name="Porsche", ShortDescription="RRrr",
                              LongDescription="RRrrRRrrRrRrrR", 
                              Image="/Img/Porche.Jfif", Price=60000,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name="BMW", ShortDescription="RRdrr",
                              LongDescription="RRrrRRrrfhRrRrrdvsR", 
                              Image="/Img/BMW.Jfif", Price=40000,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name="Mercedes", ShortDescription="uuuUUUUuuu",
                              LongDescription="UUUUuuuuuuUUUrrRrRrrR", 
                              Image="/Img/Mercedes.Jfif", Price=50000,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name="Nissan", ShortDescription="qweqwe",
                              LongDescription="AAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 
                              Image="/Img/Nissan.Jfif", Price=10000,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.Last()},
                    new Car { Name="Toyota", ShortDescription=")))",
                              LongDescription="()()()()()()", 
                              Image="/Img/Toyota.Jfif", Price=12000,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.Last()},
                    new Car { Name="Lada", ShortDescription="Edem Edem",
                              LongDescription="Edem Edem V soednee selo", 
                              Image="/Img/Lada.Jfif", Price=2228,
                              IsFavorite = true, Available = true, Category = _carsCategory.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        public Car GetObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
