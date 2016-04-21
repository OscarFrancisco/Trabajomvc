using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Infraestructura
{
    public interface IContexto : IDisposable, IRepositorio
    {
        IDbSet<Customer> Usuario { get; set; }
        
    }
}
