using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SubmitData(student s)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
    }
}