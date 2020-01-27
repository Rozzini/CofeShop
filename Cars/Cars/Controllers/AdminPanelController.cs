using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Data.Model;
using Cars.Data.Interface;
using Cars.Data.Repository;
using Cars.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public AdminPanelController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _carsCategory = iCarsCategory;
        }

        [HttpGet]
        public IActionResult List()
        {
            ViewBag.Title = "Auto Veo";
            CarsListViewModel Obj = new CarsListViewModel();
            Obj.GetAllCars = _allCars.Cars;
            Obj.CurrentCategory = "Autos";

            return View(Obj);
        }

        //public ViewResult Edit(int CarId)
        //{
        //    Car car = CarRepository
        //    Car car = CarRepository
        //        .FirstOrDefault(g => g.CarId == CarId);
        //    return View(car);
        //}



        //public ViewResult Index()
        //{
        //    var AdminCars = new CategotyListViewModel
        //    {
        //        CatCar = _allCars.Cars
        //    };

        //    return View(AdminCars);
        //}
    }
}