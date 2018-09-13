using System.Web.Http;
using SimpleInjector;
using WebApplication3.Controllers;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;

namespace WebApplication3
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			Container container = new Container();
			container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			container.Register<CardsController>();
			container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
			container.Verify();
			GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
			//GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
