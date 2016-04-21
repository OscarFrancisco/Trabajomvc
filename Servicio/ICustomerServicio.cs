using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public interface ICustomerServicio<T>
    {
        T Insertar(T instancia);
        int Editar(T instancia);
        int Eliminar(T instancia);
        IEnumerable<T> Listar(string nombre);
        T Obtener(int Identity);
    }
}
