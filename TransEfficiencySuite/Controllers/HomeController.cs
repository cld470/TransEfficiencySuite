using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransEfficiencySuite.Models;
using System.Collections;
using System.Web.Script.Serialization;

namespace TransEfficiencySuite.Controllers
{
    public class HomeController : Controller
    { 

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.PostType = "PostA";
            ViewBag.SignID = "R1-1-24";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GenerateSignPost(Sign userSign)
        {

                        
            return Json(new { PostLength = "5", PostType = "Type 3" });
        }
    }
}
