using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebApplication.Models;

namespace AjaxWebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Person person = new Person() {ID = 2, Name = "AJ", BirthDate = new DateTime(year: 1986, month: 01, day: 01)};

            return View(person);
        }

        public string HitMe()
        {
            return "Pow !!! Punch !!! - ";
        }
    }
}