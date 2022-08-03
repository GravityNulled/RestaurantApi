using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi.DTOs.FoodItemDto
{
    public class ReadFoodItemDto
    {
        public int FoodItemId { get; set; }
        public string FoodName { get; set; } = null!;
        public double FoodPrice { get; set; }
    }
}