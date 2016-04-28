using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Aplicacion.Formularios
{
    public partial class Formulario_Lista : System.Web.UI.Page
    {
        public ICustomerServicio<Customer> _UsuarioServicio { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.repetidor.DataSource = Listar();
                this.repetidor.DataBind();
                this.repetidor.Dispose();
            }
        }
        private IEnumerable<Customer> Listar()
        {
            return _UsuarioServicio.GetList(null);
        }
        private int Editar(Customer customer)
        {
            if(customer!= null)
                return _UsuarioServicio.Edit(customer);
            throw new Exception("Error al editar");            
        }
        private int Eliminar(Customer customer)
        {
            if(customer != null)
                return _UsuarioServicio.Delete(customer);
            throw new Exception("Error al Eliminar");
        }

        
    }
}