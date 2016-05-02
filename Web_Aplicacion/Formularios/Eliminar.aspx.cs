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
    public partial class Eliminar : System.Web.UI.Page, IView
    {
        readonly IPresentadorBase _OperacionEliminar;
        public Eliminar()
        {
            _OperacionEliminar = new PresentadorBase(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                int.TryParse(Page.Request.QueryString["id"], out id);
                hdfId.Value = id.ToString();
                MyCustomer = _OperacionEliminar.Get();
            }
        }
        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            _OperacionEliminar.UpdateViewDelete();
            Response.Redirect(hlRegresar.NavigateUrl);
        }
        public override void Dispose()
        {
            _OperacionEliminar.Dispose();
        }
        public Customer MyCustomer
        {
            get {
                    return new Customer() { 
                                            Id = int.Parse(hdfId.Value) 
                                          };
                }
            set {
                    if (value != null)
                    {
                        hdfId.Value = value.Id.ToString();
                        lblNombre.Text = value.Nombre;
                        lblCorreo.Text = value.Correo;
                        lblTelefono.Text = value.Telefono;
                        lblNombreUsuario.Text = value.NombreUsuario;
                    }
                }
        }
        
    }
}