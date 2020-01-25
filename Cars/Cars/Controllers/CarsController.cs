using Cars.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cars.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCategory;
        }

        public ViewResult List()
        {
            var Cars = _allCars.Cars;
            return View(Cars);
        }
    }
}
