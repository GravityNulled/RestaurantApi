using RestaurantApi.Models;

namespace RestaurantApi.DTOs.OrderDetailsDto
{
    public class ReadOrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public int FoodItemId { get; set; }
        public FoodItem FoodItems { get; set; } = null!;
        public decimal FoodItemPrice { get; set; }
        public int OrderMastersId { get; set; }
        public ReadOrderMasterDto OrderMasters { get; set; } = null!;
    }
}