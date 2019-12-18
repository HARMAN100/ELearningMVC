using ELearningMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        ELearningEntities1 instance = new ELearningEntities1();

        public ActionResult HTML()
        {
            var draft = instance.Subjects.Where(d => d.Category== "HTML");
            return View(draft);
        }

        public ActionResult Java()
        {
            var draft = instance.Subjects.Where(d => d.Category == "java");
            return View(draft);
        }
        public ActionResult Css()
        {
            var draft = instance.Subjects.Where(d => d.Category == "css");
            return View(draft);
        }
        public ActionResult JavaScript()
        {
            var draft = instance.Subjects.Where(d => d.Category == "javascript");
            return View(draft);
        }
        public ActionResult CSharp()
        {
            var draft = instance.Subjects.Where(d => d.Category == "csharp");
            return View(draft);
        }


        // GET: Data/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Data/Create
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

        // GET: Data/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Data/Edit/5
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

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Data/Delete/5
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
