using AdventureWorksCenter.BusinessEntities.Products;

namespace AdventureWorksCenter.BusinessServices.Interfaces
{
    public interface IProductService
    {
        ProductEntity GetProductsByID(int? id);
    }
}
