using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Domain.Model;
public class CustomerDto
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string Name { get; set; }
    public string? Email { get; set; }
    public ICollection<OrderDto> Orders { get; set; } = new List<OrderDto>();
}
