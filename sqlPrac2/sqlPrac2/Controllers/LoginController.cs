using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sqlPrac2.Models;

namespace sqlPrac2.Controllers
{
    public class LoginController : Controller
    {
        db_logininfoEntities1 db = new db_logininfoEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_logininfo lg)
        {
            if(ModelState.IsValid)
            {
                var data = db.tbl_logininfo.Where(x => x.username == lg.username && x.password == lg.password).FirstOrDefault();

                if (data == null)
                {
                    ViewBag.Message = "Username or password is wrong";
                    return View();
                }
                else
                {
                    //if login is succesfull, create a session
                    Session["username"] = lg.username;
                    return RedirectToAction("Index", "Home");
                }
            }
            
            return View();
        }
    }
}