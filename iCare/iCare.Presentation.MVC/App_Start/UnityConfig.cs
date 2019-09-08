using iCare.Infrastructure.Data;
using iCare.Infrastructure.Data.Uow;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace iCare.Presentation.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			container.RegisterType<IUnitOfWork, UnitOfWork>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}