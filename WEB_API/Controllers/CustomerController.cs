using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEB_API.Controllers
{
    [Authorize]
    public class CustomerController : ApiController
    {
        private readonly ICustomerServicio<Customer> _UsuarioServicio = null;
        public CustomerController() { }
        public CustomerController(ICustomerServicio<Customer> usuarioServicio)
        {
            this._UsuarioServicio = usuarioServicio;
        }
        // GET api/Customer
        public IEnumerable<Customer> Get(string nombre)
        {
            return _UsuarioServicio.GetList(nombre).ToList();
        }
        public HttpResponseMessage Get(int id)
        {
            var MyCustomer = _UsuarioServicio.Get(id);
            if (null != MyCustomer)
            {
                return Request.CreateResponse<Customer>(HttpStatusCode.OK, MyCustomer);
            }
            return Request.CreateResponse<Customer>(HttpStatusCode.NotFound, MyCustomer);
        }
        // POST api/Customer
        public HttpResponseMessage Post([FromBody]Customer value)
        {
            if (null != value)
                return Request.CreateResponse<Customer>(HttpStatusCode.Created, _UsuarioServicio.Insert(value));
            return Request.CreateResponse<Customer>(HttpStatusCode.NotFound, value);
        }
        // PUT api/Customer/5      
        public void Put(int id, [FromBody]Customer value)
        {
            value.Id = id;
            _UsuarioServicio.Edit(value);
        }
        // DELETE api/Customer/5
        public void Delete(int id)
        {
            var customer = new Customer() { Id = id };
            _UsuarioServicio.Delete(customer);
        }
    }
}
