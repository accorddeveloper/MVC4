using MvcWcfCrudDemo.MyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWcfCrudDemo.Controllers
{
    public class CustomerController : Controller
    {
        CustomerClient db = new CustomerClient();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.GetCustomer());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer obj)
        {
            db.Save(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            var cust = db.GetCustomer().FirstOrDefault(x => x.ID == id);
            return View(cust);
        }

        [HttpPost]
        public ActionResult Edit(Customer obj)
        {
            db.Save(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            var cust = db.GetCustomer().FirstOrDefault(x => x.ID == id);
            return View(cust);
        }

        public ActionResult Delete(int? id)
        {
            var cust = db.GetCustomer().FirstOrDefault(x => x.ID == id);
            return View(cust);
        }

        [HttpPost]
        public ActionResult Delete(Customer obj)
        {
            db.Delete(obj.ID.ToString());
            return RedirectToAction("Index");
        }
    }
}