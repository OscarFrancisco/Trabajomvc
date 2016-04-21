using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Infraestructura;

namespace Servicio
{
    public class CustomerServicio : ICustomerServicio<Customer>
    { 
        readonly IContexto _context;
        public CustomerServicio(IContexto context)
        {
            this._context = context;
        }
        public Customer Insertar(Customer instancia)
        {
            _context.Usuario.Add(instancia);
            _context.SaveChanges();
            return instancia;  
        }

        public int Editar(Customer instancia)
        {
            var Usuario = Obtener(instancia.Id);
            Usuario = instancia;
            return _context.SaveChanges();
        }

        public int Eliminar(Customer instancia)
        {
            var Instancia = Obtener(instancia.Id);
            _context.Usuario.Remove(Instancia);
            return _context.SaveChanges();
        }

        public IEnumerable<Customer> Listar(string nombre)
        {
            return _context.Usuario.Where(x=>x.Nombre == nombre).ToList();
        }
        public Customer Obtener(int Identity)
        {
            return _context.Usuario.Where(c => c.Id == Identity).FirstOrDefault();
        }
    }
        
}
