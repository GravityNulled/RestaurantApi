using RestaurantApi.Models;

namespace RestaurantApi.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> Delete(int id);
        Task<Customer> SaveAsync(Customer customer);
    }
}