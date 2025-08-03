using MediatR;

namespace CustomerManagement.Application.Commands
{
    public record CreateCustomerCommand(string Name, string Email) : IRequest<int>;
}
