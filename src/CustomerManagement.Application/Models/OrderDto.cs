using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Domain.Model;
public class OrderDto
{
    public int Id { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public decimal TotalAmount { get; set; }
    public int CustomerId { get; set; }  // FK
    public CustomerDto Customer { get; set; } = null!;
}
