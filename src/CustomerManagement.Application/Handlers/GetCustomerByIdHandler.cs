using AutoMapper;
using CustomerManagement.Application.Queries;
using CustomerManagement.Domain.Model;
using CustomerManagement.Domain.Repository;
using MediatR;

namespace CustomerManagement.Application.Handlers
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto?>
    {
        private readonly ICustomerRepository _repo;
        private readonly IMapper _mapper;
        public GetCustomerByIdHandler(ICustomerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<CustomerDto?> Handle(GetCustomerByIdQuery request, CancellationToken ct)
        {
            var result = await _repo.GetByIdAsync(request.Id);
            var customerResult = _mapper.Map<CustomerDto>(result);
            return customerResult;
        }
    }
}
