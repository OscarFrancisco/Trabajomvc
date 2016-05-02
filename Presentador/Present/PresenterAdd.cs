using Presentador.Modelo;
using Presentador.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Present
{
    public class PresenterAdd : IPresenter
    {
        protected readonly IView _vista;
        protected IModeloOperaciones _operaciones;
        public PresenterAdd(IView vista)
        {
            _operaciones = new ModeloOperaciones();
            _vista = vista;
        }
        public void UpdateView()
        {
            _operaciones.Add(_vista.MyCustomer);
        }


    }
}
