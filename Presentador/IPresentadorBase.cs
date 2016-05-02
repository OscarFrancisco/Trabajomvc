using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador
{
    public interface IPresentadorBase : IDisposable
    {
        void UpdateViewAdd();
        void UpdateViewEdit();
        void UpdateViewDelete();
        Customer Get();
        IEnumerable<Customer> GetAll();
    }
}
