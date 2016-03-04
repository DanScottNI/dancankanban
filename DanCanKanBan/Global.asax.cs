using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DanCanKanBan.DataModel.Interfaces;
using DanCanKanBan.Services.Configuration;
using DanCanKanBan.Services.Interfaces;
using DanCanKanBan.Services.Session;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace DanCanKanBan.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            var dataModelAssembly = typeof(IUnitOfWork).Assembly;

            var dataModelRegistrations =
                from type in dataModelAssembly.GetExportedTypes()
                where type.Namespace == "DanCanKanBan.DataModel.UnitOfWork"
                where type.GetInterfaces().Any()
                select new { Service = type.GetInterfaces().Single(), Implementation = type };

            foreach (var reg in dataModelRegistrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Scoped);
            }

            var serviceAssembly = typeof(IUserService).Assembly;

            var serviceRegistrations =
               from type in serviceAssembly.GetExportedTypes()
               where type.Namespace == "DanCanKanBan.Services.Services"
               where type.GetInterfaces().Any()
               select new { Service = type.GetInterfaces().Single(), Implementation = type };

            foreach (var reg in serviceRegistrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Scoped);
            }

            container.Register<IConfigurationSettings, WebConfigurationSettings>(Lifestyle.Scoped);
            container.Register<IUserSession, WebUserSession>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            // This is an extension method from the integration package as well.
            container.RegisterMvcIntegratedFilterProvider();

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
