using AdventureWorksCenter.DataAccess.DataModels;
using System.Data.Entity;

namespace AdventureWorksCenter.DataAccess.Repository
{
    public class GenericRepository<T> where T : class
    {
        private AdventureWorksDbContext _context;
        private DbSet<T> dbSet;

        public GenericRepository(AdventureWorksDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public T GetByID(int? Id)
        {
            return dbSet.Find(Id);
        }

    }
}
