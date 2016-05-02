using Dominio;
using Presentador;
using Presentador.Vista;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Aplicacion.Formularios
{
    public partial class Insertar : System.Web.UI.Page, IView
    {
        readonly IPresentadorBase _OperacionEditar;
        public Insertar()
        {
            _OperacionEditar = new PresentadorBase(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            _OperacionEditar.UpdateViewAdd();
            Response.Redirect(hlRegresar.NavigateUrl);
        }
        public Customer MyCustomer
        {
            get
            {
                return new Customer()
                {
                    Correo = txtCorreo.Text,
                    Nombre = txtNombre.Text,
                    NombreUsuario = txtNombreUsuario.Text,
                    Telefono = txtTelefono.Text
                };
            }
            set
            {
                if (value != null)
                {
                    txtNombre.Text = value.Nombre;
                    txtCorreo.Text = value.Correo;
                    txtTelefono.Text = value.Telefono;
                    txtNombreUsuario.Text = value.NombreUsuario;
                }
            }
        }
        public override void Dispose()
        {
            _OperacionEditar.Dispose();
        }
    }
}