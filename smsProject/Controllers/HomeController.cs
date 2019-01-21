using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smsProject.Controllers
{
    public class HomeController : Controller
    {
        private Models.StudentInfoEntities db = new Models.StudentInfoEntities();
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}