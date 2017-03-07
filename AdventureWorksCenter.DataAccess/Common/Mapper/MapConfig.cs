using AdventureWorksCenter.BusinessEntities.Products;
using AdventureWorksCenter.DataAccess.DataModels;

namespace AdventureWorksCenter.DataAccess.Common.Mapper
{
    public static class MapConfig
    {

        public static void Initialize()
        {
            AutoMapper.Configuration.MapperConfigurationExpression config = new AutoMapper.Configuration.MapperConfigurationExpression();
            config.CreateMap<Product, ProductEntity>();
            AutoMapper.Mapper.Initialize(config);
        }
    }
}
