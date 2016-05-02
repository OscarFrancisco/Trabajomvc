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
using Presentador;
using Presentador.Vista;


namespace Presentador
{
    public class AutofacConfig  
    {
        public static IContainerProvider _containerProvider;
        
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerHttpRequest();
            _containerProvider = new ContainerProvider(builder.Build());
        }
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }
    }
}