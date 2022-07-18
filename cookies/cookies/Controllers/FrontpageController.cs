using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cookies.Controllers
{
    public class FrontpageController : Controller
    {
        // GET: Frontpage
        public ActionResult Index()
        {
            HttpCookie cookie1 = Request.Cookies["username"];
            HttpCookie cookie2 = Request.Cookies["password"]; 
            if((cookie1 != null) && (cookie2 != null))
            {
                ViewBag.Message1 = Request.Cookies["username"].Value.ToString();
                ViewBag.Message2 = Request.Cookies["password"].Value.ToString();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}