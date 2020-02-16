using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsData.Models;
using CarsRepository.Interface;
//using Cars.Data.Repository;
using CarsServices.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarsServices.Controllers
{
    public class AdminPanelController : Controller
    {
        ICarRepository _Car;
        
        public AdminPanelController(ICarRepository iCar)
        {
            _Car = iCar;
        }

        [HttpGet]
        public ViewResult Index()
        {           
            return View(_Car.GetAllCars());
        }

        public ViewResult Edit(int CarId)
        {
            Car car = _Car.GetAllCars()
             .FirstOrDefault(C => C.CarId == CarId);
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(Car Cars)
        {
            if (ModelState.IsValid)
            {
                _Car.SaveCar(Cars);
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
            Car deletedCar = _Car.DeleteCar(CarId);
            //bool isDeleted = _Car.DeleteCar(CarId)
            //if (isDeleted) 
            //if (deletedCar == null)
            //{
            //    TempData["message"] = string.Format("Car was deleted");
            //}
            return RedirectToAction("Index");
        }
       
    }
}