﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Private()
        {
            return View();
        }

        public ActionResult Artist()
        {
            return View();
        }
    }
}