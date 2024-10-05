using ApiWithSolid.Application.MappingImplementation;
using ApiWithSolid.Application.MappingInterface;
using ApiWithSolid.Application.UsecaseInterface;
using Microsoft.Extensions.DependencyInjection;

namespace ApiWithSolid.Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductMapper, ProductMapper>();
            return services;
        }
    }
}
