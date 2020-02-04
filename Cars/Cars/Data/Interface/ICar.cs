using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Interface
{
    public interface ICar
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetFavoriteCars { get; }
        Car GetObjectCar(int CarId);

        void SaveCar(Car Cars);

        Car DeleteCar(int CarId);
    }
}
