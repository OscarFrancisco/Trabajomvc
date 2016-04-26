using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Infraestructura;
using System.Data.Entity;

namespace Servicio
{
    public class CustomerServicio : ICustomerServicio<Customer>
    { 
        readonly IRepositorio _context;
        public CustomerServicio(IRepositorio context)
        {
            this._context = context;
        }
        public Customer Insert(Customer instancia)
        {
            _context.Customers.Add(instancia);
            _context.SaveChanges();
            return instancia;  
        }
        public int Edit(Customer instancia)
        {
            var Usuario = Get(instancia.Id);
            Usuario.Nombre = instancia.Nombre;
            Usuario.NombreUsuario = instancia.NombreUsuario;
            Usuario.Telefono = instancia.Telefono;
            Usuario.Correo = instancia.Correo;
            return _context.SaveChanges();
        }
        public int Delete(Customer instancia)
        {
            var Instancia = Get(instancia.Id);
            _context.Customers.Remove(Instancia);
            return _context.SaveChanges();
        }
        public IEnumerable<Customer> GetList(string nombre)
        {
            var xY = _context as AppContext;
            var connec = xY.Database.Connection.ConnectionString;
            try
            {
                return _context.Customers.Where(x => x.Nombre == (nombre ?? x.Nombre)).ToList();
            }
            catch (System.Exception){
                return new List<Customer>();
            }
        }
        public Customer Get(int Identity)
        {
            return _context.Customers.Where(c => c.Id == Identity).FirstOrDefault();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
