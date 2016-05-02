using Autofac;
using Autofac.Integration.Wcf;
using Dominio;
using Infraestructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebServicesWCF
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<WebServicesWCF.CustomerService>().As<WebServicesWCF.ICustomerService>();
            builder.RegisterType<AppContext>().As<IRepositorio>();
            builder.RegisterType<CustomerServicio>().As<ICustomerServicio<Customer>>();
            var container = builder.Build();
            AutofacHostFactory.Container = container;   //Install-Package Autofac.Wcf
        }
    }
}