using Dominio;
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
    public partial class Formulario_Lista : System.Web.UI.Page
    {
        public ICustomerServicio<Customer> _UsuarioServicio { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar();
            }
        }
        private void Cargar()
        {
            this.repetidor.DataSource = Listar();
            this.repetidor.DataBind();
            this.repetidor.Dispose();
        }
        private IEnumerable<Customer> Listar()
        {
            return _UsuarioServicio.GetList(null);
        }
        protected void Eliminar_Click(object sender, EventArgs e)
        {
            int MyId;
            int.TryParse(hdf_Id.Value, out MyId);
            if (MyId == 0)
                throw new Exception("Error al Eliminar");
            _UsuarioServicio.Delete(new Customer() { Id = MyId });
            Cargar();
        }
        public override void Dispose()
        {
            _UsuarioServicio.Dispose();
        }
    }
}