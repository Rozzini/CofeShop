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

        public ViewResult Edit(int CarId)
        {
            Car car = _allCars.Cars
             .FirstOrDefault(C => C.CarId == CarId);
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(Car Cars)
        {
            if (ModelState.IsValid)
            {
                _allCars.SaveCar(Cars);
                TempData["message"] = string.Format("Изменения в игре \"{0}\" были сохранены", Cars.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(Cars);
            }
        }

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