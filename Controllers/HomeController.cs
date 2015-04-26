using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema2_MiniMagazin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to The Little Cake Shop!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
