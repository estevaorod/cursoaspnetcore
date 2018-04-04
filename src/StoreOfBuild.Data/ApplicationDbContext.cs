using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Produties { get; set; }
    }
}