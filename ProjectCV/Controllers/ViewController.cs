using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCV.Controllers
{
    public class ViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}