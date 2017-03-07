using AdventureWorksCenter.BusinessServices.Interfaces;
using AdventureWorksCenter.BusinessServices.Services;
using AdventureWorksCenter.DataAccess.UnitOfWork;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace AdventureWorksCenter.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IProductService, ProductService>(new HierarchicalLifetimeManager());

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}