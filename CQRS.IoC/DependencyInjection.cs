
using CQRS.Infra.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using CQRS.Application.Mappings;
using CQRS.Application.Interfaces;
using CQRS.Application.Services;

namespace CQRS.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
             //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            //), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddAutoMapper(typeof(DomainDTOMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("CQRS.Application");

            services.AddMediatR(myhandlers);

            return services;
        }
    }
}
