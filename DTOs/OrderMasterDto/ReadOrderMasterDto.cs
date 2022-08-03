using RestaurantApi.DTOs.OrderDetailsDto;
using RestaurantApi.Models;

namespace RestaurantApi.DTOs
{
    public class ReadOrderMasterDto
    {
        public int OrderMasterId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public decimal GrandTotal { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<ReadOrderDetailDto> OrderDetail { get; set; } = null!;
    }
}