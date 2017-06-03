using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using namesOfAllah.Models;
namespace namesOfAllah.Controllers
{
    public class HomeController : Controller
    {
        Names NamesContext = new Names();
        public ActionResult Index()
        {
            Name name = NamesContext.ListOfNames["Аллах"];
            ViewBag.Name = name;
            return View();
        }
        public ActionResult Gospod()
        {
            Name name = NamesContext.ListOfNames["Господь"];
            ViewBag.Name = name;
            return View();
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}

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