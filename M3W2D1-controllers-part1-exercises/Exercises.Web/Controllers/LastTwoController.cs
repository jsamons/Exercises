using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class LastTwoController : Controller
    {
        // GET: LastTwo
        public ActionResult Index()
        {
            return View("LastTwo");
        }
        public ActionResult LastTwo()
        {
            return View();
        }
        public ActionResult LastTwoResult(List<string> list)
        {
            return View(list);
        }
        
    }
}