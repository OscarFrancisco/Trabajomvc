using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio;
using Infraestructura;
using Dominio;
using Autofac;
using Autofac.Builder;
using System.Reflection;
using Autofac.Integration.Web;

namespace Web_Aplicacion
{
    public class AutofacConfig  
    {
        public static IContainerProvider _containerProvider;
        
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>().InstancePerRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerRequest();
            _containerProvider = new ContainerProvider(builder.Build());
        }
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }
    }
}