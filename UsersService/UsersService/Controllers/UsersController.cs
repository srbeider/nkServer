using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace UsersService.Controllers
{
    public class UsersController : Controller
    {
        private class User
        {
            public string Name { get; set; }
        }

        public JsonResult Index()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Marc" });
        }

        public JsonResult Nuria()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Nuria" });
        }

        public JsonResult Marc()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Marc" });
        }

        public JsonResult Pablo()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Pablo" });
        }

        public JsonResult Ray()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Ray" });
        }

        public JsonResult Steff()
        {
            Thread.Sleep(10000);
            return Json(new User { Name = "Steff" });
        }
    }
}