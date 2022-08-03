using Microsoft.EntityFrameworkCore;
using RestaurantApi.Data;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Customer> Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
            return new Customer();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                return customer;
            }
            return new Customer();
        }

        public async Task<Customer> SaveAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}