﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Infraestructura
{
    public class AppContext : DbContext, IUnitOfWork, IRepositorio
    {
        public IDbSet<Customer> Customers {get;set;}
        public AppContext(): base("DefaultConnection")
        {
            var string_ = this.Database.Connection.ConnectionString;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configuration.CustomerConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
