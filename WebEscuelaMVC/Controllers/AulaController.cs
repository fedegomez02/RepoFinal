using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVC.Models;


namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private AulaContext context = new AulaContext();

        public ActionResult Index()
        {
            return View("Index", context.Aulas.ToList());

        }
        public ActionResult Create()
        {
            Aula aula = new Aula();

            return View("Create",aula);
        }

        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else { return View("Create", aula); }
        }
        public ActionResult Details(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            else{ return View(aula);}
            return View(aula);
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if(id == null)
            {
                return HttpNotFound();
            }
            else { return View("edit", aula); }
        }
        [HttpPost]
        public ActionResult Editar(int id,Aula aula) {

            if(id != aula.Id)
            {
                return HttpNotFound();
            }
           if(ModelState.IsValid)
            {
                context.Aulas.AddOrUpdate(aula);
                context.SaveChanges();

               
            }

            return View("editar", aula);
        }
        [HttpGet]

       public ActionResult TraerUno(int id)
        {
            Aula aula = context.Aulas.Find(id);


            return View("details",aula);
        }
    }
}