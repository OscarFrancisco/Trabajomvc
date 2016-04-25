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
        public Customer Insertar(Customer instancia)
        {
            _context.Customers.Add(instancia);
            _context.SaveChanges();
            return instancia;  
        }

        public int Editar(Customer instancia)
        {
            var Usuario = Obtener(instancia.Id);
            Usuario.Nombre = instancia.Nombre;
            Usuario.NombreUsuario = instancia.NombreUsuario;
            Usuario.Telefono = instancia.Telefono;
            Usuario.Correo = instancia.Correo;
            return _context.SaveChanges();
        }

        public int Eliminar(Customer instancia)
        {
            var Instancia = Obtener(instancia.Id);
            _context.Customers.Remove(Instancia);
            return _context.SaveChanges();
        }

        public IEnumerable<Customer> Listar(string nombre)
        {
            var xy = _context as DbContext;
            var str = xy.Database.Connection.ConnectionString;
            //.Database.Connection.ConnectionString;
            return _context.Customers.Where(x=>x.Nombre == (nombre ?? x.Nombre)).ToList();
        }
        public Customer Obtener(int Identity)
        {
            return _context.Customers.Where(c => c.Id == Identity).FirstOrDefault();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
        
}
