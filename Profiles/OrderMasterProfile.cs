using AutoMapper;
using RestaurantApi.DTOs;
using RestaurantApi.DTOs.FoodItemDto;
using RestaurantApi.DTOs.OrderDetailsDto;
using RestaurantApi.Models;

namespace RestaurantApi.Profiles
{
    public class OrderMasterProfile : Profile
    {
        public OrderMasterProfile()
        {
            CreateMap<OrderMaster, CreateOrderMasterDto>().ReverseMap();
            CreateMap<ReadOrderMasterDto, OrderMaster>().ReverseMap();
            CreateMap<CreateOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<ReadOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<FoodItem, CreateFoodItemDto>().ReverseMap();
            CreateMap<FoodItem, ReadFoodItemDto>().ReverseMap();
        }
    }
}