using ELearningMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMVC.Controllers
{
    public class HomeController : Controller
    {

        ELearningEntities1 instance = new ELearningEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HTML()
        {

            var data = instance.Subjects.SingleOrDefault(d=>d.Category=="HTML");

            return View(data);

           // return View();
        }

        public ActionResult CSS()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JavaScript()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JAVA()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CSharp()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}