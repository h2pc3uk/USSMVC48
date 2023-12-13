using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using USSMVC48.Data;
using USSMVC48.Services;

namespace USSMVC48
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(App_Start.WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // set up Autofac
            var builder = new ContainerBuilder();

            // Register MVC controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register types
            builder.RegisterType<USSMVC48Context>().AsSelf().InstancePerRequest();
            builder.RegisterType<FormService>().AsSelf().InstancePerRequest();

            // Build the container
            var container = builder.Build();

            // Set the dependency resolver to be Autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
