using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELearningMVC.Models;
using System.Data;

namespace ELearningMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }

        public ActionResult Login(AdminLogin data) {

            DataTable tbl = new DataTable();
            connection obj_connection = new connection();

            tbl = obj_connection.srchRecord("Select * from Login where Admin='" + data.Name + "' and Password='" + data.Password + "'");
            if (tbl.Rows.Count > 0)
            {
                return View("AdminZone");
            }
            else {
                return View("Invalid");
            }
            

        }
        

    }
}