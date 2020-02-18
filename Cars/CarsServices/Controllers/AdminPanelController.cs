using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsData.Models;
using CarsRepository.Interface;
using CarsServices.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarsServices.Controllers
{
    public class AdminPanelController : Controller
    {
        ICarRepository _сarRepository;
        
        public AdminPanelController(ICarRepository iAllCars)
        {
            _сarRepository = iAllCars;
        }

        [HttpGet]
        public ViewResult Index()
        {           
            return View(_сarRepository.GetAllCars());
        }

        public ViewResult Edit(int CarId)
        {
            Car car = _сarRepository.GetAllCars()
             .FirstOrDefault(C => C.CarId == CarId);
            return View(car);
        }

        [HttpPost]
        public ActionResult Edit(Car Cars)
        {
            if (ModelState.IsValid)
            {
                _сarRepository.SaveCar(Cars);
                TempData["message"] = string.Format("Changes\"{0}\" were saved", Cars.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(Cars);
            }
        }

        public ActionResult Create(Car Cars)
        {
            if (ModelState.IsValid)
            {
                _сarRepository.CreateCar(Cars);                
                return RedirectToAction("Index");
            }
            else
            { 
                return View(Cars); 
            }
            
        }

        [HttpPost]
        public ActionResult Delete(int CarId)
        {
             _сarRepository.DeleteCar(CarId);            
             TempData["message"] = string.Format("Car doesnt exist");           
             return RedirectToAction("Index");
        }
       
    }
}