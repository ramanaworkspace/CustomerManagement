using CustomerManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Domain.Repository;
public interface IOrderRepository : IBaseRepository<Order>
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task<Order?> GetByIdAsync(int id);
    Task AddAsync(Order entity);
    void Update(Order entity);
    void Delete(Order entity);
    Task SaveChangesAsync();
    Task<IEnumerable<Order>> GetOrdersByDateAsync(DateTime date);
}
