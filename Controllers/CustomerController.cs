using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<Customer>> GetAll()
        {
            var customers = await _repository.GetAll();
            return Ok(customers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            var customers = await _repository.GetByIdAsync(id);
            return Ok(customers);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer customer)
        {
            var customerPosted = await _repository.SaveAsync(customer);
            return CreatedAtAction("GetById", new { id = customer.CustomerId }, customer);
        }
    }
}