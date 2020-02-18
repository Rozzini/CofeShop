using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarsData.Models;
using CarsServices.ViewModels;
using CarsRepository.Interface;
using System.Collections.Generic;

namespace CarsServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsAPIController : ControllerBase
    {

        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _carsCategoryRepository;
        public CarsAPIController(ICarRepository iAllCars, ICategoryRepository iCarsCategory)
        {
            _carRepository = iAllCars;
            _carsCategoryRepository = iCarsCategory;
        }

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> GetCar()
        {

            return _carRepository.GetAllCars();
        }

        //GET: api/Cars/5
        [HttpGet("{id}")]
        public IEnumerable<Car> GetCar(int id)
        {

            return _carRepository.GetCarsByCategory(id);
        }        
    }
}
