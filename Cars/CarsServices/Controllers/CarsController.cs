//using Cars.Data;
using CarsRepository.Interface;
using CarsData.Models;
//using Cars.Data.Repository;
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
        private readonly ICar _Car;
        private readonly ICategory _CarsCategory;
       
        public CarsController(ICar iAllCars, ICategory iCarsCategory)
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
