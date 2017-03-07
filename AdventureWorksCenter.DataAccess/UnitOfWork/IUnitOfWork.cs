using AdventureWorksCenter.DataAccess.DataModels;
using AdventureWorksCenter.DataAccess.Repository;

namespace AdventureWorksCenter.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {

        GenericRepository<Product> ProductRepository { get; }
    }
}
