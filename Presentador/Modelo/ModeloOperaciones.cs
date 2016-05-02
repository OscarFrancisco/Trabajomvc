using Dominio;
using Infraestructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Modelo
{
    public class ModeloOperaciones : IModeloOperaciones
    {
        public  ICustomerServicio<Customer> _usuarioServicio;
        public ModeloOperaciones()
        {
            _usuarioServicio = new CustomerServicio(new AppContext());
        }
        public Customer Add(Customer customer)
        {
            return _usuarioServicio.Insert(customer);
        }
        public int Edit(Customer customer)
        {
            return _usuarioServicio.Edit(customer);
        }
        public int Delete(Customer customer)
        {
            return _usuarioServicio.Delete(customer);
        }
        public IEnumerable<Customer> GetAll()
        {
            return _usuarioServicio.GetList(null);
        }
        public Customer Get(int id)
        {
            return _usuarioServicio.Get(id);
        }

        public void Dispose()
        {
            _usuarioServicio.Dispose();
        }
    }
}
