using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Models;

namespace WebApplication1
{
    public static class WebApiDependenciesConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// register stuff
			// configure simple injector
			Container container = new Container();
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Register<IRepository<Card>, CardRepository>();
			container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
			container.Verify();
			GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

		}
	}
}