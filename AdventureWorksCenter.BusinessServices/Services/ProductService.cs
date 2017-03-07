using System;
using AdventureWorksCenter.BusinessEntities.Products;
using AdventureWorksCenter.BusinessServices.Interfaces;
using AdventureWorksCenter.DataAccess.UnitOfWork;
using AutoMapper;
using AdventureWorksCenter.DataAccess.DataModels;

namespace AdventureWorksCenter.BusinessServices.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unit;
        public ProductService(IUnitOfWork unit)
        {
            _unit = unit;
        }
        public ProductEntity GetProductsByID(int? id)
        {
            var product = _unit.ProductRepository.GetByID(id);

            var productEntity = Mapper.Map<Product, ProductEntity>(product);

            return productEntity;

        }
    }
}
