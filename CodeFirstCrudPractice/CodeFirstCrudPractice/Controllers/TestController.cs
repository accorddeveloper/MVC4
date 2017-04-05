using CodeFirstCrudPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstCrudPractice.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult PersList(string name,string address)
        {
            MyDatabase db = new MyDatabase();
            Person persons = new Person();

            persons.Name = name;
            persons.Address = address;

            db.persons.Add(persons);
            db.SaveChanges();
            return Json(db.persons);


        }
    }
}