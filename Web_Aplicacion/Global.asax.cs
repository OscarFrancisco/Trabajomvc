using Autofac;
using Autofac.Integration.Web;
using Dominio;
using Infraestructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Web_Aplicacion;

namespace Web_Aplicacion
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            AutofacConfig.RegisterAutoFac();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta al cerrarse la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se produce un error no controlado

        }

        public IContainerProvider ContainerProvider
        {
            get { return AutofacConfig._containerProvider; }
        }

        
    }
}
