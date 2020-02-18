using CarsRepository.Interface;
using CarsData.Models;
using CarsServices.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarsServices.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _carsCategoryRepository;
       
        public CarsController(ICarRepository iAllCars, ICategoryRepository iCarsCategory)
        {
            _carRepository = iAllCars;
            _carsCategoryRepository = iCarsCategory;
        }

        [HttpGet]
        
        public IActionResult ShowCarsByCategory(int id)
        {
            CarsListViewModel actionGetCarsbyCategory = new CarsListViewModel();
            actionGetCarsbyCategory.GetCarsByCategory = _carRepository.GetCarsByCategory(id);
            return View(actionGetCarsbyCategory);            
        }

        [HttpGet]

        public IActionResult ShowAllCars()
        {
            CarsListViewModel Obj = new CarsListViewModel();
            Obj.GetCarsByCategory = _carRepository.GetAllCars();
            return View(Obj);
        }


    }
}
