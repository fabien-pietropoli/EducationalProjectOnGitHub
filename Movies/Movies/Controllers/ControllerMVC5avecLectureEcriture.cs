using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class ControllerMVC5avecLectureEcriture : Controller
    {
        // GET: ControllerMVC5avecLectureEcriture
        public ActionResult Index()
        {
            return View();
        }

        // GET: ControllerMVC5avecLectureEcriture/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControllerMVC5avecLectureEcriture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControllerMVC5avecLectureEcriture/Create
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

        // GET: ControllerMVC5avecLectureEcriture/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControllerMVC5avecLectureEcriture/Edit/5
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

        // GET: ControllerMVC5avecLectureEcriture/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControllerMVC5avecLectureEcriture/Delete/5
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
