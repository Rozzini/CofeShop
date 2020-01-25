using Cars.Data.Interface;
using Cars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cars.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
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
    }
}
