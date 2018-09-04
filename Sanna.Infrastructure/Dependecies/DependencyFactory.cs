using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Sanna.Infrastructure.Dependecies
{
    public static class DependencyFactory
    {
        private static IUnityContainer _container;

        public static IUnityContainer Container
        {
            get { return _container; }
            private set { _container = value; }
        }

        static DependencyFactory()
        {
            _container = new UnityContainer();
        }

        public static void RegisterType<InterfaceType, ClassType>() where ClassType : InterfaceType
        {
            Container.RegisterType<InterfaceType, ClassType>();
        }
    }
}
