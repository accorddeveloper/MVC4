using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCrudEvidenceDemo.Controllers
{
    public class AccountController : Controller
    {
        AdventureEntities db = new AdventureEntities();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User U)
        {
            int count = db.Users.Where(x => x.UserName == U.UserName && x.Password == U.Password).Count();
            if(count > 0)
            {
                FormsAuthentication.SetAuthCookie(U.UserName, true);
                return RedirectToAction("Home", "Product");
            }
            else
            {
                ViewBag.Error = "Try again!";
                return View();
            }
            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}