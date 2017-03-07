using AdventureWorksCenter.DataAccess.DataModels;
using System.Data.Entity;

namespace AdventureWorksCenter.DataAccess.Repository
{
    public class GenericRepository<T> where T : class, IGenericInterface
    {
        private AdventureWorksDbContext _context;
        private DbSet<T> dbSet;

        public GenericRepository()
        {
            _context = new AdventureWorksDbContext();
            dbSet = _context.Set<T>();
        }

    }
}
