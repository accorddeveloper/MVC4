using GoogleAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleAuth.Controllers
{
    public class MessageController : Controller
    {
        List<Message> mList = new List<Message>()
        {
            new Message { Test = "<b>ABC</b>" },
            new Message { Test = "ABC" },
            new Message { Test = "ABC" },
            new Message { Test = "ABC" }
        };
        // GET: Message
        public ActionResult Index()
        {
            return View(mList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Message message)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(message);
        }
    }
}