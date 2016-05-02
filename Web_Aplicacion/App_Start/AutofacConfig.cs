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
using Web_Aplicacion.Formularios;
using System.Web.UI;

namespace Web_Aplicacion
{
    public class AutofacConfig  
    {
        public static IContainerProvider _containerProvider;
        
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PresentadorBase>().As<IPresentadorBase>().InstancePerRequest();
            _containerProvider = new ContainerProvider(builder.Build());
        }
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }
    }
}