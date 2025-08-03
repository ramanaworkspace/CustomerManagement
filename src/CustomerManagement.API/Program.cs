using AutoMapper;
using CustomerManagement.Application;
using CustomerManagement.Application.Commands;
using CustomerManagement.Application.Mappings;
using CustomerManagement.Application.Queries;
using CustomerManagement.Application.Validators;
using CustomerManagement.Infrastructure;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        builder.Services.AddValidatorsFromAssemblyContaining<CreateCustomerValidator>();
        builder.Services.AddAuthorization();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllCustomersQuery>());
        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();
        app.Run();

    }
}