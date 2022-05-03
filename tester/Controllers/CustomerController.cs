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
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly object Id;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<CustomerModel>>> GetCustomerModel()
        public IActionResult GetCustomerModelAsync()
        {
            var customerModel =  _context.CustomerModel.AsQueryable();
            
            return Ok(new
            {
                StatusCode = 200,
                customerModel
               


            });
                
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerModel>> GetCustomerModel(int id)
        {
            var customerModel = await _context.CustomerModel.FindAsync(id);

            if (customerModel == null)
            {
                return NotFound(new
                {
                    StatusCode = 404,
                    Message = "Customer Not Found"
                });

            }
            else
            {


                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Customer Found",
                    customerModel
                });


            }
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerModel(int id, CustomerModel customerModel)
        {
            if (id != customerModel.CarId)
            {
                return BadRequest(new
                {
                    StatusCode = 404,
                    Message = "Customer not found"
                }
                    );
            }

            _context.Entry(customerModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerModelExists(id))
                {
                    return NotFound(new
                    {
                        StatusCode = 404,
                        Message = "Customer not found"
                    }

                        );
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerModel>> PostCustomerModel(CustomerModel customerModel)
        {
            _context.CustomerModel.Add(customerModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerModel", new { id = customerModel.CarId,  }, customerModel);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomerModel(int id)
        {
            var customerModel =  _context.CustomerModel.Find(id);
            if (customerModel == null)
            {
              return NotFound(new
              {
                  StatusCode = 404,
                  Message = "Customer not found"


              });
            }
            else {
            }

             _context.CustomerModel.Remove(customerModel);
             _context.SaveChangesAsync();
            
             Console.Write("Successfully Removed Customer ");
      
            return NoContent();
        }

        private bool CustomerModelExists(int id)
        {
            return _context.CustomerModel.Any(e => e.CarId == id);
        }
    }
}
