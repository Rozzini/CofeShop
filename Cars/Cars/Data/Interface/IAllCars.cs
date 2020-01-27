using Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data.Interface
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        
        IEnumerable<Car> GetFavCars { get;}

        Car GetObjectCar(int CarId);
    }
}
