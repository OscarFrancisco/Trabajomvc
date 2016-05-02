using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio;
using Infraestructura;
using Dominio;
using Autofac;
using System.ServiceModel;


namespace WebServicesWCF
{
    public class AutofacConfig  
    {
        public static IContainer RegisterAutoFac()
        {   
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>().InstancePerLifetimeScope();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerLifetimeScope();

            builder
  .Register(c => new ChannelFactory<CustomerServicio>(
    new BasicHttpBinding(),
    new EndpointAddress("http://localhost/CustomerService.svc")))
  .SingleInstance();

            return builder.Build();
        }
    }
}