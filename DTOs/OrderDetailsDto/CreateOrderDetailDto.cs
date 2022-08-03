namespace RestaurantApi.DTOs.OrderDetailsDto
{
    public class CreateOrderDetailDto
    {
        public int Quantity { get; set; }
        public int FoodItemId { get; set; }
        public decimal FoodItemPrice { get; set; }
    }
}