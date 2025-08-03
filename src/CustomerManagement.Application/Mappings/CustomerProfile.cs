using AutoMapper;
using CustomerManagement.Domain.Model;

namespace CustomerManagement.Application.Mappings;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerDto, Customer>();
    }
}
