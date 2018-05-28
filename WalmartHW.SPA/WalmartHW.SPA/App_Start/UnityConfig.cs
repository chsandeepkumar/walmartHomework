using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using WalmartHW.Component.Contracts;
using WalmartHW.Component.Service;

namespace WalmartHW.SPA
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            HttpConfiguration config = new HttpConfiguration
            {
                DependencyResolver = new UnityDependencyResolver(container)
            };
            container.RegisterType<IWalmartApi, WalmartApiService>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}