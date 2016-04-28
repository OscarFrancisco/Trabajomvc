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
    public partial class Insertar : System.Web.UI.Page
    {
        public ICustomerServicio<Customer> _UsuarioServicio { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Customer MyCustomer = new Customer()
                                {
                                    Nombre=this.txtNombre.Text,
                                    Correo=this.txtCorreo.Text,
                                    NombreUsuario=this.txtNombreUsuario.Text,
                                    Telefono=this.txtTelefono.Text
                                };
            _UsuarioServicio.Insert(MyCustomer);
            Redireccionar();
        }
        private void Redireccionar()
        {
            this.Response.Redirect("Formulario_Lista.aspx");
        }
        public override void Dispose()
        {
            _UsuarioServicio.Dispose();
        }
    }
}