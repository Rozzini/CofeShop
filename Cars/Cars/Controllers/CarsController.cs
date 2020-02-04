using Cars.Data.Interface;
using Cars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cars.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICar _Car;
        private readonly ICategory _carsCategory;

        public CarsController(ICar iAllCars, ICategory iCarsCategory)
        {
            _Car = iAllCars;
            _carsCategory = iCarsCategory;
        }

        [HttpGet]
        public IActionResult List()
        {
            ViewBag.Title = "Auto Veo";
            CarsListViewModel Obj = new CarsListViewModel();
            Obj.GetAllCars = _Car.Cars;
            Obj.CurrentCategory = "Autos";

            return View(Obj);
        }

        public ViewResult GermanCars()
        {
            var GermanCars = new CarsListViewModel
            {
                GetAllCars = _Car.Cars
            };

            return View(GermanCars);
        }

        public ViewResult JapanesCars()
        {
            var JapanesCars = new CarsListViewModel
            {
                GetAllCars = _Car.Cars
            };

            return View(JapanesCars);
        }

        public ViewResult RussianCars()
        {
            var RussinaCategory = new CarsListViewModel
            {
                GetAllCars = _Car.Cars
            };

            return View(RussinaCategory);
        }
    }
}
