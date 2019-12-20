using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    public class CursoosController : Controller
    {
        private bool x;

        // GET: Cursoos Index
        public ActionResult Index()
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Cursoes.ToList());
            }
          
        }

        // GET: Cursoos/Details/5
        public ActionResult Details(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Cursoes.Where(x => x.Id == id).FirstOrDefault());
            }
                return View();
        }

        // GET: Cursoos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursoos/Create
        [HttpPost]
        public ActionResult Create(Curso curso)
        {
            try
            {
                // TODO: Add insert logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    db.Cursoes.Add(curso);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursoos/Edit/5
        public ActionResult Edit(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Cursoes.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Cursoos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Curso curso)
        {
            try
            {
                // TODO: Add update logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    db.Entry(curso).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursoos/Delete/5
        public ActionResult Delete(int id)
        {
            using (CRUDEntidades db = new CRUDEntidades())
            {
                return View(db.Cursoes.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Cursoos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Curso curso)
        {
            try
            {
                // TODO: Add delete logic here
                using (CRUDEntidades db = new CRUDEntidades())
                {
                    curso = db.Cursoes.Where(x => x.Id == id).FirstOrDefault();
                    db.Cursoes.Remove(curso);
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
