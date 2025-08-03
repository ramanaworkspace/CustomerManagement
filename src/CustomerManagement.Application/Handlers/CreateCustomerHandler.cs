using CustomerManagement.Application.Commands;
using CustomerManagement.Domain.Model;
using CustomerManagement.Domain.Repository;
using MediatR;

namespace CustomerManagement.Application.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly ICustomerRepository _repo;
        public CreateCustomerHandler(ICustomerRepository repo) => _repo = repo;

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken ct)
        {
            var entity = new Customer(request.Name, request.Email);
            await _repo.AddAsync(entity);
            return entity.Id;
        }
    }
}
