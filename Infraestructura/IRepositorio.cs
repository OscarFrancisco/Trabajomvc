using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public interface IRepositorio : IUnitOfWork
    {
        IDbSet<Customer> Customers { get; set; }
    }
}
