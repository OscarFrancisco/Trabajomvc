using Dominio;
using Infraestructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServicesWCF
{
    public class CustomerService : ICustomerService
    {
        public ICustomerServicio<Customer> _usuarioServicio { get; set; }

        public CustomerService()
        {
            _usuarioServicio = new Servicio.CustomerServicio(new AppContext());
        } 

        public Customer Get(int Id)
        {
            return _usuarioServicio.Get(Id);
        }

        public Customer Add(Customer customer)
        {
            return _usuarioServicio.Insert(customer);
        }

        public int Update(Customer customer)
        {
            return _usuarioServicio.Edit(customer);
        }
        public int Delete(Customer instancia)
        {
            return _usuarioServicio.Delete(instancia);
        }
        public IEnumerable<Customer> GetAll(string nombre)
        {
            return _usuarioServicio.GetList(nombre);
        }
    }
}
