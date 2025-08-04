using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CustomerManagement.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
