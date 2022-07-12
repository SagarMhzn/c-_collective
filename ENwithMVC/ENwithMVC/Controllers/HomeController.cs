using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENwithMVC.Models;
using System.Data.Entity;

namespace ENwithMVC.Controllers
{
    public class HomeController : Controller
    {
        studentContext db = new studentContext();
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student s)
        {
            db.students.Add(s);
            int res = db.SaveChanges();
            return View();
        }

        public ActionResult Edit(int id)
        {
            var data = db.students.Where(x =>x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(student s)
        {
            db.Entry(s).State = EntityState.Modified;
            int res = db.SaveChanges();
            if(res > 0)
            {
                ModelState.Clear();
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var data = db.students.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(student s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int res = db.SaveChanges();
            if (res > 0)
            {
                ModelState.Clear();
            }
            return View("Index");
        }
    }
}