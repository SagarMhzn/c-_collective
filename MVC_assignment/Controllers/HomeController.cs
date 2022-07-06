using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_assignment.Models;

namespace MVC_assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: displayHome
        
        public ActionResult Index()
        {
            student s1 = new student()
            {
                Id = 101,
                Name = "sagar",
                Age =20,
                Address = "samakushi",
                isPass = true,
            };
            return View(s1);
        }

        public ActionResult template()
        {
            student s2 = new student()
            {
                Id = 102,
                Name = "bishal",
                Age = 07,
                Address = "manamaiju",
                isPass = true,
            };

            
            return View(s2);
        }

        public ActionResult displayHome()
        {
            return View();
        }
    }
}