using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public interface ICustomerServicio<T> : IDisposable
    {
        T Insert(T instancia);
        int Edit(T instancia);
        int Delete(T instancia);
        IEnumerable<T> GetList(string nombre);
        T Get(int Identity);
    }
}
