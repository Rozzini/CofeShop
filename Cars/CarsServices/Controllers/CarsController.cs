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
        private readonly ICarRepository _Car;
        private readonly ICategoryRepository _CarsCategory;
       
        public CarsController(ICarRepository iAllCars, ICategoryRepository iCarsCategory)
        {
            _Car = iAllCars;
            _CarsCategory = iCarsCategory;
        }

        [HttpGet]
        
        public IActionResult ShowCarsByCategory(int id)
        {
            CarsListViewModel Obj = new CarsListViewModel();            
            Obj.GetCarsByCategory = _Car.GetCarsByCategory(id);
            return View(Obj);            
        }

        

    }
}
