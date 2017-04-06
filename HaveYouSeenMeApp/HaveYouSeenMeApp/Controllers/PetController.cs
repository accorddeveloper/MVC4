using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaveYouSeenMeApp.Models;
using HaveYouSeenMeApp.Models.BusinessModel;
using System.IO;
namespace HaveYouSeenMeApp.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            ViewBag.Message = "File has been uploaded";
            return View();
        }

        public ActionResult PictureUpload()
        {
            return View();
        }

        [HttpPost]       
        public ActionResult PictureUpload(PictureViewModel picture)
        {
            if(picture.PictureFile.ContentLength > 0)
            {
                string filePath = Server.MapPath("/Content/Uploads");
                string fileName = picture.PictureFile.FileName;
                string saveFileName = Path.Combine(filePath, fileName);
                picture.PictureFile.SaveAs(saveFileName);
                PetManagement.CreateThumbnail(filePath, fileName, picture.ImageHeight, picture.ImageWidth, true);
                return RedirectToAction("Index");
            }
            
            return View();
        }
    }
}