using Dominio;
using Presentador.Modelo;
using Presentador.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador
{
    public class PresentadorBase : IPresentadorBase 
    {
        protected readonly IView _vista;
        protected IModeloOperaciones _operaciones;
        public PresentadorBase(IView vista)
        {
            _operaciones = new ModeloOperaciones();
            _vista = vista;
        }
        public void UpdateViewAdd()
        {
            _operaciones.Add(_vista.MyCustomer);
        }
        public void UpdateViewEdit()
        {
            _operaciones.Edit(_vista.MyCustomer);
        }
        public void UpdateViewDelete()
        {
            _operaciones.Delete(_vista.MyCustomer);
        }
        public Customer Get()
        {
            return _operaciones.Get(_vista.MyCustomer.Id);
        }
        public IEnumerable<Customer> GetAll()
        {
            return _operaciones.GetAll();
        }
        public void Dispose()
        {
            _operaciones.Dispose();
        }
    }
}
