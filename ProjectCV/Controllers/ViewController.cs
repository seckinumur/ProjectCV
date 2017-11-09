using DAL.Repo;
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
            var gonder = UserRepo.UserFindView();
            return View(gonder);
        }
    }
}