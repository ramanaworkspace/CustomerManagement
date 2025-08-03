using CustomerManagement.Domain.Model;
using MediatR;

namespace CustomerManagement.Application.Queries
{
    public record GetCustomerByIdQuery(int Id) : IRequest<CustomerDto?>;
}
