}using Ganadero.BussinesEntities;
using Ganadero.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ganadero.Web.Controllers
{
    public class ServiciosController : Controller
    {
        private InterfaceServicio repository;
        
    public ServiciosController(InterfaceServicio repository)
        {
            this.repository = repository;

        }

        [HttpGet]
        public ViewResult Index(string query ="")
        {
            var datos = repository.ByQueryAll(query);
            return View("Index", datos);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Servicio servicio)
        {
            RedirectToAction("Create",servicio);

        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var data = repository.Find(id);
            return View("Edit", data);
        }

        [HttpPost]
        public ActionResult Edit(Servicio servicio)
        {
            repository.Update(servicio);
            TempData["UpdateSuccess"] = "Se Actualizó Correctamente";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            TempData["UpdateSuccess"] = "Se Eliminó Correctamente";
            return RedirectToAction("Index");
        }
    }
    
}