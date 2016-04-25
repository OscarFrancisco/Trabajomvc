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
        private readonly ICustomerServicio<Customer> _UsuarioServicio = null;

        public CustomerController(){}

        public CustomerController(ICustomerServicio<Customer> usuarioServicio)
        {
            this._UsuarioServicio = usuarioServicio;
        }
        public ActionResult Index(string name)
        {
            return View(this._UsuarioServicio.GetList(name));
        }
        public ActionResult Details(int id)
        {
            return View(this._UsuarioServicio.Get(id));
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
                this._UsuarioServicio.Insert(Usuario);
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
                this._UsuarioServicio.Edit(Usuario);
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
                this._UsuarioServicio.Delete(Usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
