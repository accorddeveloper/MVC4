using HaveYouSeenMeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaveYouSeenMeApp.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Send()
        {
            return View();
        }

        public ActionResult Submit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Submit(MessageModel obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }
            ModelState.AddModelError("", "Some data is required to proceed");
            return View(obj);
        }


        [HttpPost]
        public ActionResult Send(MessageModel obj)
        {
            if (String.IsNullOrEmpty(obj.From))
            {
                ModelState.AddModelError("From", "Enter your name.");
            }
            if (String.IsNullOrEmpty(obj.Email))
            {
                ModelState.AddModelError("Email", "Enter your email address.");
            }
            if (String.IsNullOrEmpty(obj.Subject))
            {
                ModelState.AddModelError("Subject", "Enter your mail subject.");
            }
            if (String.IsNullOrEmpty(obj.Message))
            {
                ModelState.AddModelError("Message", "Enter your message.");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }
            ModelState.AddModelError("", "Some data is required to proceed");
            return View(obj);

            //if (!ModelState.IsValid)
            //{
            //    ModelState.AddModelError("", "Some data is required to proceed");
            //    return View(obj);
            //}
            //else
            //{
            //    return RedirectToAction("ThankYou");
            //}

        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}