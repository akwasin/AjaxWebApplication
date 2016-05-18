﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebApplication.Models;

namespace AjaxWebApplication.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Create(int id)
        {
            Car car = new Car {PersonId = id};
            return PartialView(viewName: "_Create", model: car);
        }
    }
}