using Dominio;
using Presentador;
using Presentador.Vista;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Aplicacion.Formularios
{
    public partial class Formulario_Lista : System.Web.UI.Page, IView
    {
        readonly IPresentadorBase _OperacionListar;
        public Formulario_Lista()
        {
            _OperacionListar = new PresentadorBase(this);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.repetidor.DataSource = _OperacionListar.GetAll();
            this.repetidor.DataBind();
            this.repetidor.Dispose();
        }
        public override void Dispose()
        {
            _OperacionListar.Dispose();
        }
        public Customer MyCustomer{get;set;}
    }
}