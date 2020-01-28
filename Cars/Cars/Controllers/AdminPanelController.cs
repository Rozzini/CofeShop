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
         IAllCars _allCars;
        

        public AdminPanelController(IAllCars iAllCars)
        {
            _allCars = iAllCars;
        }

        [HttpGet]
        public ViewResult Index()
        {
           

            return View(_allCars.Cars);
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