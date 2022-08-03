using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemRepository _repository;

        public FoodItemController(IFoodItemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<FoodItem>> GetAll()
        {
            var foodItem = await _repository.GetAll();
            return Ok(foodItem);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<FoodItem>> GetById(int id)
        {
            var foodItem = await _repository.GetByIdAsync(id);
            return Ok(foodItem);
        }

        [HttpPost]
        public async Task<ActionResult<FoodItem>> Post(FoodItem foodItem)
        {
            var foodItemPosted = await _repository.SaveAsync(foodItem);
            return CreatedAtAction("GetById", new { id = foodItem.FoodItemId }, foodItem);
        }
    }
}