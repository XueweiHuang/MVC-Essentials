using MVCRockers.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    //[Authorize (Roles ="Admin", Users ="Joe")]
    public class HomeController : Controller
    {
        

        //means when you do  when you enter home/index
        public ActionResult Index()
        {
            return View();
        }


        //[OutputCache(Duration =1800, VaryByParam ="id")]

        //[HandleError(ExceptionType =typeof(DivideByZeroException), View ="matherror")]
        //means when you enter about

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        


        //that's what you see when you enter home/foo
        public ActionResult foo()
        {
            return View("About");
        }

        [MyLoggingFilter]

      
        public ActionResult Contact()
        {
            ViewBag.Message = "send us what you think";

            return View();
        }


        [HttpPost]
        public ActionResult Contact (string message)
        {
            // todo: save and act on it
            ViewBag.Message = "Thanks for the feedback!";
            return PartialView("_Thanksforfeedback");
        }

        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "special")
                return new HttpStatusCodeResult(403);
            if (format == "text")
                return Content("you rock!");
            else if (format == "json")
                return Json(new { password = "You Rock", expires = DateTime.UtcNow.ToShortDateString() },
                    JsonRequestBehavior.AllowGet);
            else if (format == "clean")
                return PartialView();
            return View();


        }
    }
}