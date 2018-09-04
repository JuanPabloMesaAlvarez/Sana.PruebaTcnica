using Sanna.Application.Services.Contracts;
using Sanna.Application.Services.Impl;
using Sanna.Domain.Repositories;
using Sanna.Infrastructure.Dependecies;
using Sanna.Persistence.Repositories;

namespace Sanna.Application.Utils
{
    public static class RegisterAppTypes
    {
        public static void RegisterApplicationTypes()
        {
            RegisterDomainRepositories();
            RegisterApplicationServices();
        }

        private static void RegisterDomainRepositories()
        {
            DependencyFactory.RegisterType<IProductsRepository, ProductsRepository>();
        }

        private static void RegisterApplicationServices()
        {
            DependencyFactory.RegisterType<IProductsServices, ProductsServices>();
        }
    }
}
