using CustomerManagement.DataAccess;
using CustomerManagement.Domain.Model;
using CustomerManagement.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;
public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync() =>
        await _context.Customers.ToListAsync();

    public async Task<Customer?> GetByIdAsync(int id) =>
        await _context.Customers.FindAsync(id);

    public async Task AddAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
    }

    public void Update(Customer entity) =>
        _context.Customers.Update(entity);

    public void Delete(Customer entity) =>
        _context.Customers.Remove(entity);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();

    public async Task<IEnumerable<Order>> GetCustomerOrdersAsync(int customerId) =>
        await _context.Orders
                      .Where(o => o.CustomerId == customerId)
                      .ToListAsync();
}
