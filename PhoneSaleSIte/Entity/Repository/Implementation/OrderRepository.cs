using System;
using System.Threading.Tasks;
using Entity.Models;
using Entity.Repository.Interface;

namespace Entity.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
    }
}
