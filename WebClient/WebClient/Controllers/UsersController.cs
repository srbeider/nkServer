using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    [ServiceCallFilter]
    public class UsersController : Controller
    {
        public ActionResult Nuria()
        {
            return View();
        }

        public ActionResult Marc()
        {
            return View();
        }

        public ActionResult Pablo()
        {
            return View();
        }

        public ActionResult Ray()
        {
            return View();
        }

        public ActionResult Steff()
        {
            return View();
        }
    }
}