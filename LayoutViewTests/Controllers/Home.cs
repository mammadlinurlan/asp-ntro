using System;
using Microsoft.AspNetCore.Mvc;

namespace LayoutViewTests.Controllers
{
    public class Home:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
