using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransEfficiencySuite.Controllers
{
    public class SignController : Controller
    {
        //
        // GET: /Sign/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Sign/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Sign/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sign/Create

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

        //
        // GET: /Sign/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Sign/Edit/5

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

        //
        // GET: /Sign/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Sign/Delete/5

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
