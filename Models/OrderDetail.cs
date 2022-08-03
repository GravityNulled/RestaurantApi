namespace RestaurantApi.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public int FoodItemId { get; set; }
        public FoodItem FoodItems { get; set; } = null!;
        public decimal FoodItemPrice { get; set; }
        public int OrderMastersId { get; set; }
        public OrderMaster OrderMasters { get; set; } = null!;
    }
}