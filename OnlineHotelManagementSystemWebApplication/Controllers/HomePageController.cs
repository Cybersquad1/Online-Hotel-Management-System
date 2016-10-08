using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHotelManagementSystemWebApplication.Controllers
{
    public class HomePageController : Controller
    {
        //
        // GET: /HomePage/
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }

    }
}
