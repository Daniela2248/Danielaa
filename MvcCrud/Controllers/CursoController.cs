using MvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrud.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso/ Index
        public ActionResult Index()
        {
            using (CRUDEntidades db = new CRUDEntidades() )
            {
                return View(db.Cursoes.ToList()); 
            }
            return View();
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            using(CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Estudiantes.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        public ActionResult Create(Estudiante estudiante) 
        {
            try
            {
                // TODO: Add insert logic here
                using (CRUDEntidades db = new CRUDEntidades()) 
                {
                    db.Estudiantes.Add(estudiante);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Estudiantes.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Estudiante estudiante)
        {
            try
            {
                // TODO: Add update logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    db.Entry(estudiante).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Estudiantes.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Estudiante estudiante)
        {
            try
            {
                // TODO: Add delete logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    estudiante = db.Estudiantes.Where(x => x.Id == id).FirstOrDefault();
                    db.Estudiantes.Remove(estudiante);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
