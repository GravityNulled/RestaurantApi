using Microsoft.EntityFrameworkCore;
using RestaurantApi.Data;
using RestaurantApi.Interfaces;
using RestaurantApi.Models;

namespace RestaurantApi.Repository
{
    public class MasterDetailRepository : IMasterDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public MasterDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<OrderMaster> Delete(int id)
        {
            var orderMaster = await _context.OrderMasters.FindAsync(id);
            if (orderMaster != null)
            {

                _context.Remove(orderMaster);
                await _context.SaveChangesAsync();
                return orderMaster;
            }
            return new OrderMaster();
        }

        public async Task<IEnumerable<OrderMaster>> GetAll()
        {
            return await _context.OrderMasters.ToListAsync();
        }

        public async Task<OrderMaster> GetByIdAsync(int id)
        {
            var orderMaster = await _context.OrderMasters.FindAsync(id);
            if (orderMaster != null)
            {

                return orderMaster;
            }
            return new OrderMaster();
        }

        public async Task<OrderMaster> SaveAsync(OrderMaster orderMaster)
        {
            _context.OrderMasters.Add(orderMaster);
            await _context.SaveChangesAsync();
            return orderMaster;
        }
    }
}