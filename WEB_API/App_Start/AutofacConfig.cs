using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Servicio;
using Infraestructura;
using Dominio;
using Autofac;
using Autofac.Integration.WebApi;
using Autofac.Builder;

using WEB_API.Controllers;
using System.Web.Http;
using WEB_API;
using System.Reflection;

namespace WEB_API.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>().InstancePerApiRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerApiRequest();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}