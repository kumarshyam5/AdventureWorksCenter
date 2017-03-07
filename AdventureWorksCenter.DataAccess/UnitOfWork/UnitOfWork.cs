using AdventureWorksCenter.DataAccess.DataModels;
using AdventureWorksCenter.DataAccess.Repository;

namespace AdventureWorksCenter.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private GenericRepository<Product> _productRepository;
        private AdventureWorksDbContext _context;

        public UnitOfWork(AdventureWorksDbContext context)
        {
            _context = context;
        }
        public GenericRepository<Product> ProductRepository
        {

            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new GenericRepository<Product>(_context);
                }

                return _productRepository;
            }

        }



    }
}
