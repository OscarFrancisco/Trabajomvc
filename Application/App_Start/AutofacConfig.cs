using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Servicio;
using Infraestructura;
using Dominio;
using Application.Controllers;

namespace Application.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CustomerController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerHttpRequest();
            builder.RegisterType<Dominio.Customer>().InstancePerHttpRequest();

            builder.RegisterModelBinderProvider();
            var Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

        }
    }
}