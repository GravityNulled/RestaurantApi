using RestaurantApi.DTOs.OrderDetailsDto;
using RestaurantApi.Models;

namespace RestaurantApi.DTOs
{
    public class CreateOrderMasterDto
    {
        public string OrderNumber { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public decimal GrandTotal { get; set; }
        public int CustomerId { get; set; }
        public List<CreateOrderDetailDto> OrderDetail { get; set; } = null!;
    }
}