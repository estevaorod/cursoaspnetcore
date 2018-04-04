using System;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;
using Microsoft.EntityFrameworkCore;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conn)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(conn)
            );
        }
    }
}