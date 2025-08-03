using CustomerManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Domain.Repository;
public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<Customer?> GetByIdAsync(int id);
    Task<IEnumerable<Customer>> GetAllAsync();
    Task AddAsync(Customer entity);
    void Update(Customer entity);
    void Delete(Customer entity);
    Task SaveChangesAsync();
    Task<IEnumerable<Order>> GetCustomerOrdersAsync(int customerId);
}
