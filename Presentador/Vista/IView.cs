using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Vista
{
    public interface IView : IDisposable
    {
        Customer MyCustomer { get; set; }
   }
}
