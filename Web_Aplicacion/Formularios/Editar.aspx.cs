using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Aplicacion.Formularios
{
    public partial class Editar : System.Web.UI.Page
    {
        public ICustomerServicio<Customer> _UsuarioServicio { get; set; }
        private Customer _MyCustomer = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = int.Parse( Page.Request.QueryString["id"]);
                _MyCustomer = Get(id);
                MostrarValoresPorDefecto();
            }
        }

        private void MostrarValoresPorDefecto()
        {
            txtNombre.Text = _MyCustomer.Nombre;
            txtNombreUsuario.Text = _MyCustomer.NombreUsuario;
            txtTelefono.Text = _MyCustomer.Telefono;
            txtCorreo.Text = _MyCustomer.Correo;
        }
        protected void btn_Editar_Click(object sender, EventArgs e)
        {
            _MyCustomer.Id = int.Parse(Page.Request.QueryString["id"]);
            _MyCustomer.Nombre = txtNombre.Text;
            _MyCustomer.NombreUsuario = txtNombreUsuario.Text;
            _MyCustomer.Correo = txtCorreo.Text;
            _MyCustomer.Telefono = txtTelefono.Text;
            
            _UsuarioServicio.Edit(_MyCustomer);
            Redireccionar();
        }

        
        private void Redireccionar()
        {
            this.Response.Redirect("Formulario_Lista.aspx");
        }
        private Customer Get(int Id)
        {
            return _UsuarioServicio.Get(Id);
        }
        public override void Dispose()
        {
            _UsuarioServicio.Dispose();
        }
    }
}