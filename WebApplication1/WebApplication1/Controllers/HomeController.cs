using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
         [HttpPost]
         public string usingParameter(string uname,string add, string age)
        {
            return "using parameter method data are " + uname + "," + add + "," + age;
        }

        [HttpPost]
        public string usingRequest()
        {
            string username = Request["uname"];
            string address = Request["add"];
            string age = Request["age"];
            return "using request values are " + username + "," + address + "," + age;
        }
        [HttpPost]
        public string usingFormCollection(FormCollection frm)
        {
            string username =frm["uname"];
            string address = frm["add"];
            string age = frm["age"];
            return "using Form Collection values are " + username + "," + address + "," + age;
        }

        [HttpPost]
        public string usingStrongBinding(student s)
        {
            string uname = s.Username;
            string add = s.Address;
            string age = s.Age;
            return uname+add+age;
         }
    }
}