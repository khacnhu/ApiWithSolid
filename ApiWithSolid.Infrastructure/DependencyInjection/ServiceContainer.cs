using ApiWithSolid.Domain.RepositoryInterface;
using ApiWithSolid.Infrastructure.DatabaseContext;
using ApiWithSolid.Infrastructure.RepositoryImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration            
            ) 
        {
            services.AddDbContext<AppDbContext>(
                o => o.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;    
        }


    }
}
