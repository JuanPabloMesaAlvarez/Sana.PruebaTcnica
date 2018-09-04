using Sanna.Application.Utils;
using Sanna.Infrastructure.Dependecies;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Sanna.MvcApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            RegisterAppTypes.RegisterApplicationTypes();
            var container = DependencyFactory.Container;
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}