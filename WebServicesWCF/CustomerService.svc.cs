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
        public ICustomerServicio<Customer> _usuarioServicio {get; set;}
        public CustomerService(ICustomerServicio<Customer> usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }    
        public Customer Get(string id)
        {
            int Out;
            int.TryParse(id, out Out);
            return _usuarioServicio.Get(Out);
        }
        public Customer Add(Customer customer)
        {
            return _usuarioServicio.Insert(customer);
        }
        public int Update(Customer customer)
        {
            return _usuarioServicio.Edit(customer);
        }
        public int Delete(string id)
        {
            int Out;
            int.TryParse(id, out Out);
            return _usuarioServicio.Delete(new Customer() { Id = Out });
        }
        public IEnumerable<Customer> GetAll()
        {
            return _usuarioServicio.GetList(null);
        }
    }
}
