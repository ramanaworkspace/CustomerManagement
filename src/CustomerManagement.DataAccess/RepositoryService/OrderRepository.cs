using CustomerManagement.DataAccess;
using CustomerManagement.Domain.Model;
using CustomerManagement.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAllAsync() =>
            await _context.Orders.ToListAsync();

        public async Task<Order?> GetByIdAsync(int id) =>
            await _context.Orders.FindAsync(id);

        public async Task AddAsync(Order entity) =>
            await _context.Orders.AddAsync(entity);

        public void Update(Order entity) =>
            _context.Orders.Update(entity);

        public void Delete(Order entity) =>
            _context.Orders.Remove(entity);

        public async Task SaveChangesAsync() =>
            await _context.SaveChangesAsync();

        public async Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date) =>
            await _context.Orders
                          .Where(o => o.OrderDate.Date == date.Date)
                          .ToListAsync();
    }
}
