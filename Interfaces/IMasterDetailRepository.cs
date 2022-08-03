using RestaurantApi.Models;

namespace RestaurantApi.Interfaces
{
    public interface IMasterDetailRepository
    {
        Task<IEnumerable<OrderMaster>> GetAll();
        Task<OrderMaster> GetByIdAsync(int id);
        Task<OrderMaster> Delete(int id);
        Task<OrderMaster> SaveAsync(OrderMaster orderMaster);
    }
}