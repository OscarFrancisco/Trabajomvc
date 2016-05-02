using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Modelo
{
    public interface IModeloOperaciones: IDisposable
    {
        Customer Add(Customer customer);
        int Edit(Customer customer);
        int Delete(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
    }
}
