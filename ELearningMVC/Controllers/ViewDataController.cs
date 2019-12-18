using ELearningMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMVC.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        ELearningEntities1 instance = new ELearningEntities1();

        public ActionResult ViewDetails()
        {
            return View(instance.Subjects.ToList());
        }

        // GET: ViewData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViewData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewData/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Subject DataAdd)
        {
            if (!ModelState.IsValid)
                return View();
            instance.Subjects.Add(DataAdd);
            instance.SaveChanges();
            return RedirectToAction("ViewDetails");
        }

        // GET: ViewData/Edit/5
        public ActionResult Edit(int id)
        {
            var IDToEdit = (from m in instance.Subjects where m.id == id select m).First();
            return View(IDToEdit);
        }

        // POST: ViewData/Edit/5
        [HttpPost]
        public ActionResult Edit(Subject IDToEdit)
        {

            var orignalRecord = (from m in instance.Subjects where m.id== IDToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            instance.Entry(orignalRecord).CurrentValues.SetValues(IDToEdit);

            instance.SaveChanges();
            return RedirectToAction("ViewDetails");
        }

        // GET: ViewData/Delete/5
        public ActionResult Delete(Subject IDToDelete)
        {
            var d = instance.Subjects.Where(x => x.id == IDToDelete.id).FirstOrDefault();
            instance.Subjects.Remove(d);
            instance.SaveChanges();
            return RedirectToAction("ViewDetails");

        }

        // POST: ViewData/Delete/5
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
