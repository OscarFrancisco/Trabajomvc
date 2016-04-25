using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using Infraestructura;
using Dominio;
using Servicio;
using Application.Controllers;


namespace Application.App_Start
{
    public class AutofacConfig
    {

        public  void Configurar()
        {
            var builder = new ContainerBuilder();
            var container = builder.Build();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterType<CustomerController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<CustomerServicio>>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<Infraestructura.IRepositorio>().InstancePerHttpRequest();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));        
        }
    }
}