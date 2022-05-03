using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tester.Data;
using tester.Models;

namespace tester.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Car
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarModel>>> GetCarModel()
        {
            return await _context.CarModel.ToListAsync();
        }

        // GET: api/Car/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarModel>> GetCarModel(int id)
        {
            var carModel = await _context.CarModel.FindAsync(id);

            if (carModel == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "Car ID not found"
                });
            }

            return carModel;
        }

        // PUT: api/Car/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarModel(int id, CarModel carModel)
        {
            if (id != carModel.CarId)
            {
                return BadRequest(new
                {
                    StatusCode = 404,
                    Message = "Car Id not found"
                });
            }

            _context.Entry(carModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarModelExists(id))
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        Message = "Car Id not found"
                    });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Car
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarModel>> PostCarModel(CarModel carModel)
        {
            _context.CarModel.Add(carModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarModel", new { id = carModel.CarId,
                StatusCode = 200,
                Message = "Car Added Successfully"
            }, carModel);
        }

        
        
           
        // DELETE: api/Car/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarModel(int id)
        {
            var carModel = await _context.CarModel.FindAsync(id);
            if (carModel == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "Car Id NOT FOUND"
                });
            }

            _context.CarModel.Remove(carModel);
            await _context.SaveChangesAsync();

            return NoContent(
            
                );
        }

        private bool CarModelExists(int id)
        {
            return _context.CarModel.Any(e => e.CarId == id);
        }
    }
}
