using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Data.Interface;
using Cars.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    public class CateController : Controller
    {
        private readonly IAllCars _allCars;

        public CateController(IAllCars iAllCars)
        {
            _allCars = iAllCars;
          
        }
        public ViewResult Index()
        {
            var CatCars = new CategotyListViewModel
            {
                CatCar = _allCars.Cars
            };
            
            return View(CatCars);
        }
    }

}