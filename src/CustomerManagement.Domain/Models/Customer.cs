using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Domain.Model;
public class Customer
{
    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    public string? Email { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
