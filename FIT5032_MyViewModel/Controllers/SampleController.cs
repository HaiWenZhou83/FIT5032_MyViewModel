using FIT5032_MyViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyViewModel.Controllers
{
    public class SampleController : Controller
    {
        // GET: SampleController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SampleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SampleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SampleController/Create
        [HttpPost]
        public ActionResult Create(FormOneViewModel model)
        {
            try
            {
                // TODO: Add insert logic here

                string FirstName = model.FirstName;
                string LastName = model.LastName;

                ViewBag.FullName = FirstName + " " + LastName;

                return View(); ;
            }
            catch
            {
                return View();
            }
        }

        // GET: SampleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SampleController/Edit/5
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

        // GET: SampleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SampleController/Delete/5
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
