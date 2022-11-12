using FinCalculator.Application.Contracts.Persistance;
using FinCalculator.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinCalculator.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinCalculatorDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("FinCoonectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));


            services.AddScoped<IPortfolioRepository, PortfolioRepository>();


            return services;

        }

    }
}
