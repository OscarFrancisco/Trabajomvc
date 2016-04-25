using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Servicio;
using Infraestructura;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Core;

namespace Application.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerServicio<Customer> _UsuarioServicio { get; set; }

        public CustomerController(CustomerServicio usuarioServicio)
        {
            _UsuarioServicio = usuarioServicio;
        }
        public ActionResult Index(string name)
        {
            //var _Container = Container.BeginLifetimeScope();
            //var UsuarioServicio = _Container.Resolve<ICustomerServicio<Customer>>(); 
            return View(_UsuarioServicio.Listar(name));
        }
        public ActionResult Details(int id)
        {
            IRepositorio Contexto = new AppContext();
            ICustomerServicio<Customer> UsuarioServicio = new CustomerServicio(Contexto);
            return View(UsuarioServicio.Obtener(id));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Customer Usuario = new Customer() 
                                    {
                                        Nombre = collection["Nombre"],
                                        Telefono = collection["Telefono"],
                                        Correo = collection["Correo"],
                                        NombreUsuario = collection["NombreUsuario"]
                                    };
                IRepositorio Contexto = new AppContext();
                ICustomerServicio<Customer> UsuarioServicio = new CustomerServicio(Contexto);
                UsuarioServicio.Insertar(Usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return Details(id);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Customer Usuario = new Customer()
                {
                    Id = id,
                    Nombre = collection["Nombre"],
                    Telefono = collection["Telefono"],
                    Correo = collection["Correo"],
                    NombreUsuario = collection["NombreUsuario"]
                };
                IRepositorio Contexto = new AppContext();
                ICustomerServicio<Customer> UsuarioServicio = new CustomerServicio(Contexto);
                UsuarioServicio.Editar(Usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            return Details(id);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Customer Usuario = new Customer()
                {
                    Id = id
                };
                IRepositorio Contexto = new AppContext();
                ICustomerServicio<Customer> UsuarioServicio = new CustomerServicio(Contexto);
                UsuarioServicio.Eliminar(Usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
