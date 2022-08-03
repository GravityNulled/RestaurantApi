namespace RestaurantApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public long Phone { get; set; }
    }
}