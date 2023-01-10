using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestructure(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            var assembly = typeof(PostContext).Assembly.FullName;
            services.AddDbContext<PostContext>(
                options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("POSConnection"),
                        b => b.MigrationsAssembly(assembly)
                    ),
                ServiceLifetime.Transient
            );
            // Registar el patron de diseño unit of work como siclo de vida transient  => se crea una nueva instancia cada vez que se solicita
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
