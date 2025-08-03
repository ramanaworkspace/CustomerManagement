using CustomerManagement.Domain.Model;
using MediatR;

namespace CustomerManagement.Application.Queries
{
    public record GetAllCustomersQuery() : IRequest<List<CustomerDto>>;
}
