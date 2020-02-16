﻿using System.Threading.Tasks;
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

        // GET: api/Cars/5
        //[HttpGet("{id}")]
        //    public async Task<ActionResult<Car>> GetCar(int id)
        //    {
        //        //CarsListViewModel Obj = new CarsListViewModel();
        //        //Obj.GetCarsByCategory = _Car.GetCarsByCategory(id);
        //        //return (Obj);
        //        var car = await _context.Cars.FindAsync(id);

        //        if (car == null)
        //        {
        //            return NotFound();
        //        }

        //        return car;
        //    }

        //    // PUT: api/Cars/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //    // more details see https://aka.ms/RazorPagesCRUD.
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutCar(int id, Car car)
        //    {
        //        if (id != car.CarId)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(car).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CarExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/Cars
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //    // more details see https://aka.ms/RazorPagesCRUD.
        //    [HttpPost]
        //    public async Task<ActionResult<Car>> PostCar(Car car)
        //    {
        //        _context.Cars.Add(car);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("GetCar", new { id = car.CarId }, car);
        //    }

        //    // DELETE: api/Cars/5
        //    [HttpDelete("{id}")]
        //    public async Task<ActionResult<Car>> DeleteCar(int id)
        //    {
        //        var car = await _context.Cars.FindAsync(id);
        //        if (car == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Cars.Remove(car);
        //        await _context.SaveChangesAsync();

        //        return car;
        //    }

        //    private bool CarExists(int id)
        //    {
        //        return _context.Cars.Any(e => e.CarId == id);
        //    }
        //}
    }
}
