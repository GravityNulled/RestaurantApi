namespace RestaurantApi.Models
{
    public class OrderMaster
    {
        public int OrderMasterId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public decimal GrandTotal { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<OrderDetail> OrderDetail { get; set; } = null!;
    }
}