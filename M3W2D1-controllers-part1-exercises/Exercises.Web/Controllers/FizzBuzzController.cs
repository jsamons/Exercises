using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View("FizzBuzz");
        }
        public ActionResult FizzBuzz()
        {
            return View();
        }
        public ActionResult FizzBuzzDisplay(FizzBuzz fizzBuzz)
        {

            return View(fizzBuzz);
        }
    }
}