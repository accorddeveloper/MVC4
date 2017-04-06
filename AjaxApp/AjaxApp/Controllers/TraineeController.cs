using AjaxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AjaxApp.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Display()
        {
            Thread.Sleep(4000);
            List<Student> students = new List<Student>()
            {
                new Student {Name="AAA", Address="Dhaka" },
                new Student {Name="BBB", Address="Noakhali" },
                new Student {Name="CCC", Address="CTG" },
                new Student {Name="DDD", Address="Feni" },
                new Student {Name="EEE", Address="DHK" },
            };
            return PartialView(students);
        }
    }
}