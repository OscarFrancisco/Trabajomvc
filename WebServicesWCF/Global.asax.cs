﻿using Autofac;
using Autofac.Integration.Wcf;
using Dominio;
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
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<CustomerServicio>();//.As<ICustomerServicio<Customer>>();
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }
    }
}