using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface IRepositorio<T> : IUnitOfWork where T : class
    {
        IDbSet<T> Entities { get; set; }
    }
}
