using System.Threading.Tasks;
using StoreOfBuild.Domain;

namespace StoreOfBuild.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _ctx;

        public UnitOfWork(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Commit()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}