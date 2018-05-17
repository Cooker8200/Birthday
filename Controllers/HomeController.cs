using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Birthday1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime[] birthdays = new DateTime[] { Convert.ToDateTime("6/18/1982"), Convert.ToDateTime("1/5/1987"), Convert.ToDateTime("8/31/2008"),
                                                    Convert.ToDateTime("8/16/2011")};
            var anniversary = Convert.ToDateTime("3/17/2011");
            //Array[] nums = new[] { birthdays[], anniversary };

            return View(birthdays);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}