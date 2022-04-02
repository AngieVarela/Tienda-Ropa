using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaRosse_MVC.Models;

namespace TiendaRosse_MVC.Controllers
{
    public class VestuariosController : Controller
    {
        private ROSSEEntities db = new ROSSEEntities();

        // GET: Vestuarios
        public ActionResult Index()
        {
            return View(db.Vestuario.ToList());
        }

        // GET: Vestuarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vestuario vestuario = db.Vestuario.Find(id);
            if (vestuario == null)
            {
                return HttpNotFound();
            }
            return View(vestuario);
        }

        // GET: Vestuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vestuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_prenda,Talla,Color,Precio,Stock,activo")] Vestuario vestuario)
        {
            if (ModelState.IsValid)
            {
                db.Vestuario.Add(vestuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vestuario);
        }

        // GET: Vestuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vestuario vestuario = db.Vestuario.Find(id);
            if (vestuario == null)
            {
                return HttpNotFound();
            }
            return View(vestuario);
        }

        // POST: Vestuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_prenda,Talla,Color,Precio,Stock,activo")] Vestuario vestuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vestuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vestuario);
        }

        // GET: Vestuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vestuario vestuario = db.Vestuario.Find(id);
            if (vestuario == null)
            {
                return HttpNotFound();
            }
            return View(vestuario);
        }

        // POST: Vestuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vestuario vestuario = db.Vestuario.Find(id);
            db.Vestuario.Remove(vestuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
