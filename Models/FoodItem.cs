namespace RestaurantApi.Models
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        public string FoodName { get; set; } = null!;
        public double FoodPrice { get; set; }
    }
}