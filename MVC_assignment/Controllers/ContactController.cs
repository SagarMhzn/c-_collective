using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_assignment.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult displayContact()
        {
            return View();
        }
    }
}