using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presentador;
using Presentador.Vista;

namespace Web_Aplicacion.Formularios
{
    public partial class Editar : System.Web.UI.Page, IView
    {
        readonly IPresentadorBase _OperacionEditar;
        public Editar()
        {
            _OperacionEditar = new PresentadorBase(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                int.TryParse(Page.Request.QueryString["id"], out id);
                hdfId.Value = id.ToString();
                MyCustomer = _OperacionEditar.Get();
            }
        }
        protected void btn_Editar_Click(object sender, EventArgs e)
        {
            _OperacionEditar.UpdateViewEdit();
            Response.Redirect(hlRegresar.NavigateUrl);
        }
        public override void Dispose()
        {
            _OperacionEditar.Dispose();
        }
        public Customer MyCustomer
        {
            get {
                    return new Customer() { 
                                            Id = int.Parse(hdfId.Value), 
                                            Correo = txtCorreo.Text, 
                                            Nombre = txtNombre.Text, 
                                            NombreUsuario = txtNombreUsuario.Text, 
                                            Telefono = txtTelefono.Text 
                                          };
                }
            set {
                    if (value != null)
                    {
                        hdfId.Value = value.Id.ToString();
                        txtNombre.Text = value.Nombre;
                        txtCorreo.Text = value.Correo;
                        txtTelefono.Text = value.Telefono;
                        txtNombreUsuario.Text = value.NombreUsuario;
                    }
                }
        }
        
    }
}