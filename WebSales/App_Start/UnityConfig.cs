using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebSales.Models;

namespace WebSales
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IStockEngine, StockEngine>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}