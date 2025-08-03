using AutoMapper;
using CustomerManagement.Application.Queries;
using CustomerManagement.Domain.Model;
using CustomerManagement.Domain.Repository;
using MediatR;

namespace CustomerManagement.Application.Handlers
{
    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _repo;
        private readonly IMapper _mapper;
        public GetAllCustomersHandler(ICustomerRepository repo, IMapper mapper) 
        { 
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> Handle(GetAllCustomersQuery _, CancellationToken ct)
        {
            var results = await _repo.GetAllAsync();
            var customersResults = _mapper.Map<List<CustomerDto>>(results);
            return customersResults;
        }
    }
}
