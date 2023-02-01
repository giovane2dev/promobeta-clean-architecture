using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PromoBeta.Application.Interfaces;
using PromoBeta.Application.Mappings;
using PromoBeta.Application.Services;
using PromoBeta.Domain.Interfaces;
using PromoBeta.Infra.Data.Context;
using PromoBeta.Infra.Data.Repositories;

namespace PromoBeta.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfraAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(configuration.GetConnectionString("Connection"),
                a => a.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
