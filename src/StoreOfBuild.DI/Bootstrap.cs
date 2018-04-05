using System;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conn)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(conn)
            );
            
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(CategoryStorer));
            services.AddSingleton(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}