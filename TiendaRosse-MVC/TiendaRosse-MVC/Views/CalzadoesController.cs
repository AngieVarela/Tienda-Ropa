using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaRosse_MVC.Models;

namespace TiendaRosse_MVC.Views
{
    public class CalzadoesController : Controller
    {
        private ROSSEEntities db = new ROSSEEntities();

        // GET: Calzadoes
        public ActionResult Index()
        {
            return View(db.Calzado.ToList());
        }

        // GET: Calzadoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calzado calzado = db.Calzado.Find(id);
            if (calzado == null)
            {
                return HttpNotFound();
            }
            return View(calzado);
        }

        // GET: Calzadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calzadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_calzado,Talla,Color,Precio,Stock,activo")] Calzado calzado)
        {
            if (ModelState.IsValid)
            {
                db.Calzado.Add(calzado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calzado);
        }

        // GET: Calzadoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calzado calzado = db.Calzado.Find(id);
            if (calzado == null)
            {
                return HttpNotFound();
            }
            return View(calzado);
        }

        // POST: Calzadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_calzado,Talla,Color,Precio,Stock,activo")] Calzado calzado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calzado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calzado);
        }

        // GET: Calzadoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calzado calzado = db.Calzado.Find(id);
            if (calzado == null)
            {
                return HttpNotFound();
            }
            return View(calzado);
        }

        // POST: Calzadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Calzado calzado = db.Calzado.Find(id);
            db.Calzado.Remove(calzado);
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
