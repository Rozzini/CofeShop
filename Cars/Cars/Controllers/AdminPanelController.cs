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
                TempData["message"] = string.Format("Changes\"{0}\" were saved", Cars.Name);
                return RedirectToAction("Index");
            }
            else
            {
                
                return View(Cars);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Car());
        }

        [HttpPost]
        public ActionResult Delete(int CarId)
        {
            Car deletedCar = _allCars.DeleteCar(CarId);
            if (deletedCar != null)
            {
                TempData["message"] = string.Format("Car \"{0}\" was deleted",
                    deletedCar.Name);
            }
            return RedirectToAction("Index");
        }
       
    }
}