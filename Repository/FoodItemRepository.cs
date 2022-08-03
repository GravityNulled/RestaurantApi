using Microsoft.EntityFrameworkCore;
using RestaurantApi.Data;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Repository
{
    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly ApplicationDbContext _context;

        public FoodItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<FoodItem> Delete(int id)
        {
            var foodItem = await _context.Foods.FindAsync(id);
            if (foodItem != null)
            {
                _context.Remove(foodItem);
                await _context.SaveChangesAsync();
                return foodItem;

            }
            return new FoodItem();
        }

        public async Task<IEnumerable<FoodItem>> GetAll()
        {
            return await _context.Foods.ToListAsync();
        }

        public async Task<FoodItem> GetByIdAsync(int id)
        {
            var foodItem = await _context.Foods.FindAsync(id);
            if (foodItem != null)
            {
                return foodItem;

            }
            return new FoodItem();
        }

        public async Task<FoodItem> SaveAsync(FoodItem foodItem)
        {
            _context.Foods.Add(foodItem);
            await _context.SaveChangesAsync();
            return foodItem;
        }
    }
}