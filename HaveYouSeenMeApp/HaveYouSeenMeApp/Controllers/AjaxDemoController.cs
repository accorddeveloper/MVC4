using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaveYouSeenMeApp.Controllers
{
    public class AjaxDemoController : Controller
    {
        // GET: AjaxDemo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            return View();
        }
    }
}