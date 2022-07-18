using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cookies.Models;

namespace cookies.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(form f)
        {   
            if (ModelState.IsValid == true)
            {
                HttpCookie cookie1 = new HttpCookie("username");
                HttpCookie cookie2 = new HttpCookie("password");
                cookie1.Value = f.UserName;
                cookie2.Value = f.Password;
                HttpContext.Response.Cookies.Add(cookie1);
                HttpContext.Response.Cookies.Add(cookie2);
                return RedirectToAction("Index", "Frontpage");
            }
            return View();
        }
    }
}