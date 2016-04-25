using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http.Dependencies;
using Autofac;
using Autofac.Integration.Mvc;
using Application.Controllers;

namespace Application
{
    // Nota: para obtener instrucciones sobre cómo habilitar el modo clásico de IIS6 o IIS7, 
    // visite http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication // SE CARGA UNA SOLA WEB
    {
        protected void Application_Start()
        {
            RegisterAutoFac();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
        protected void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CustomerController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<Servicio.CustomerServicio>().As<Servicio.ICustomerServicio<Dominio.Customer>>().InstancePerHttpRequest();
            builder.RegisterType<Infraestructura.AppContext>().As<Infraestructura.IRepositorio>().InstancePerHttpRequest();
            builder.RegisterType<Dominio.Customer>().InstancePerHttpRequest();

            builder.RegisterModelBinderProvider();
            var Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }
    }
}