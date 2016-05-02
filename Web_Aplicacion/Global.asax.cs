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
            AutofacConfig.RegisterAutoFac();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        /// <summary>
        /// Necesario para trabajar con autofac
        /// </summary>
        public IContainerProvider ContainerProvider
        {
            get { return AutofacConfig._containerProvider; }
        }

        
    }
}
