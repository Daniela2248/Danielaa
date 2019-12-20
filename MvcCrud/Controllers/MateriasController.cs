using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class MateriasController : Controller
    {
        // GET: Materias
        public ActionResult Index()
        {
            using(CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Materias.ToList());
            }
            
        }

        // GET: Materias/Details/5
        public ActionResult Details(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Materias.Where(x => x.Id == id).FirstOrDefault());
            }
            
        }

        // GET: Materias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materias/Create
        [HttpPost]
        public ActionResult Create(Materia materia)
        {
            try
            {
                // TODO: Add insert logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    db.Materias.Add(materia);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Materias/Edit/5
        public ActionResult Edit(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Materias.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Materias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Materia materia)
        {
            try
            {
                // TODO: Add update logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    db.Entry(materia).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Materias/Delete/5
        public ActionResult Delete(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Materias.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Materias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Materia materia)
        {
            try
            {
                // TODO: Add delete logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    materia = db.Materias.Where(x => x.Id == id).FirstOrDefault();
                    db.Materias.Remove(materia);
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
