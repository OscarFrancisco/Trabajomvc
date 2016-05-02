using Dominio;
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
        readonly ICustomerServicio<Customer> _usuarioServicio;
        public CustomerService(ICustomerServicio<Customer> usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }
        public CustomerService()
        { 
            
        }
        public Customer Get(int id)
        {
            return _usuarioServicio.Get(id);
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
        public IEnumerable<Customer> GetAll()
        {
            return _usuarioServicio.GetList(null);
        }
    }
}
