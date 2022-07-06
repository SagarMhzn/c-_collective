using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_assignment.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult displayAbout()
        {
            return View();
        }
    }
}