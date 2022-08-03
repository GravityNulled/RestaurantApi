using RestaurantApi.Models;

namespace RestaurantApi.Interfaces
{
    public interface IFoodItemRepository
    {
        Task<IEnumerable<FoodItem>> GetAll();
        Task<FoodItem> GetByIdAsync(int id);
        Task<FoodItem> Delete(int id);
        Task<FoodItem> SaveAsync(FoodItem foodItem);
    }
}