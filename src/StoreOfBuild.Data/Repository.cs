using StoreOfBuild.Domain;
using System.Linq;

namespace StoreOfBuild.Data
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : Entity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public TEntity GetById(int id)
        {
            var obj = _context.Set<TEntity>().Where(x => x.Id == id);

            if(obj.Any())
                return obj.First();
            
            return null;
        }

        public void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
    }
}