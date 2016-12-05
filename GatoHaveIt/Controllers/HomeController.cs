using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GatoHaveIt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Gato Have It, Your one stop shop for cat themed merchandise!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you need assistance, please contact our Customer Service Department. ";

            return View();
        }
    }
}