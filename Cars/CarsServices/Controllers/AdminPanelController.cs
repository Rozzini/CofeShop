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
        ICategoryRepository _carsCategoryRepository;

        public AdminPanelController(ICarRepository iAllCars, ICategoryRepository iCarsCategory)
        {
            _сarRepository = iAllCars;
            _carsCategoryRepository = iCarsCategory;
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View(_сarRepository.GetAllCars());
        }

        public ViewResult Index2()
        {
            return View(_carsCategoryRepository.GetAllCategories());
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

        public ActionResult CreateCar(Car Cars)
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

        public ActionResult CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _carsCategoryRepository.CreateCategory(category);
                return RedirectToAction("Index2");
                
            }
            else
            {
                return View(category);
            }

        }

        [HttpPost]
        public ActionResult DeleteCar(int CarId)
        {
            _сarRepository.DeleteCar(CarId);
            TempData["message"] = string.Format("Car doesnt exist");
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int CategoryId)
        {
            _carsCategoryRepository.DeleteCategory(CategoryId);
            TempData["message"] = string.Format("Car doesnt exist");
            return RedirectToAction("Index");
        }

    }
}