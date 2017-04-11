using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudEvidenceDemo.Controllers
{
    public class ProductController : Controller
    {
        AdventureEntities db = new AdventureEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.ProductDescriptions.ToList());
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductDescription obj)
        {
            Thread.Sleep(3000);
            obj.rowguid = Guid.NewGuid();
            obj.ModifiedDate = DateTime.Now;
            db.ProductDescriptions.Add(obj);
            db.SaveChanges();
            return View();
        }


    }
}