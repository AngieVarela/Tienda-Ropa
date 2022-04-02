using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaRosse_MVC.Controllers
{
    public class ROSSEController : Controller
    {
        // GET: ROSSE
        public ActionResult Index()
        {
            return View();
        }

        // GET: ROSSE/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ROSSE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ROSSE/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ROSSE/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ROSSE/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ROSSE/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ROSSE/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
