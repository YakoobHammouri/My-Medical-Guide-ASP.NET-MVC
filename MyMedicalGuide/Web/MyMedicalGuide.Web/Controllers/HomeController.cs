﻿using MyMedicalGuide.Services.Contracts;
using MyMedicalGuide.Web.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMedicalGuide.Web.Controllers
{
    public class HomeController : BaseController
    {
        [OutputCache(Duration = 60 * 60)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}