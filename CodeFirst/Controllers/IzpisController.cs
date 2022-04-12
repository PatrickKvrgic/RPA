using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class IzpisController : Controller
    {
        // GET: Izpis
        public ActionResult Index()
        {
            return View();
        }

        // GET: Izpis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Izpis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Izpis/Create
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

        // GET: Izpis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Izpis/Edit/5
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

        // GET: Izpis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Izpis/Delete/5
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
