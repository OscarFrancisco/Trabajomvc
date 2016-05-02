using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class AppContext<T> : DbContext, IRepositorio<T> where T : class
    {
        public IDbSet<T> Entities { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
