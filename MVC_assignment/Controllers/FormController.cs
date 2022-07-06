using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_assignment.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult displayForm()
        {
            return View();
        }
    }
}