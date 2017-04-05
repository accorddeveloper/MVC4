using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SportsMvcApp.Models;
using System.Web.Security;

namespace SportsMvcApp.Controllers
{
    public class AccountController : Controller
    {
        private MyDbContext db = new MyDbContext();

        public ActionResult UserInRole()
        {
            return View(db.Users.ToList());
        }

        public ActionResult UserRole()
        {
            List<UserRoleViewModel> myList = new List<UserRoleViewModel>();
            UserRoleViewModel obj;
            var List = (from u in db.Users
                       join r in db.Roles on u.RoleId equals r.Id
                       select new
                       {
                           UserId = u.Id,
                           u.UserName,
                           RoleId = r.Id,
                           r.RoleName
                       }).ToList();

            foreach (var item in List)
            {
                obj = new UserRoleViewModel();
                obj.UserId = item.UserId;
                obj.UserName = item.UserName;
                obj.RoleId = item.RoleId;
                obj.RoleName = item.RoleName;
                myList.Add(obj);
            }

            return View(myList);
                       
        }
        [Authorize(Roles ="Admin")]
        public ActionResult AssignRole()
        {
            var userList = db.Users.Select(x=> new { x.Id, x.UserName });

            var roleList = db.Roles.Select(x => new { x.Id, x.RoleName });

            ViewBag.UserId = new SelectList(userList, "Id", "UserName");
            ViewBag.RoleId = new SelectList(roleList, "Id", "RoleName");
            return View();
        }        

        [HttpPost]
        public ActionResult AssignRole(int? UserId, int? RoleId)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == UserId);
            user.RoleId = Convert.ToInt32(RoleId);
            db.SaveChanges();
            return RedirectToAction("UserRole");
        }


        // GET: Account/Create
        public ActionResult Login()
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult Login(User user, string isRemember)
        {
            
            int Count = db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).Count();
            if(Count> 0)
            {
                if(isRemember != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                }
                
                return RedirectToAction("Index", "Player");
            }
            else
            {
                ViewBag.Message = "User name or Password is invalid!";
                return View(user);
            }
            
        }

        // GET: Account/Create
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
