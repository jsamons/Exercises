using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class NameController : Controller
    {
        // GET: ColorizedName
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
        public ActionResult OrderedName()
        {
            return View("OrderedName");
        }
        public ActionResult OrderedNameResult(Name name)
        {
            return View("Display", name);
        }
        public ActionResult ColorizedName()
        {
            return View();
        }
        public ActionResult ColorizedNameResult(Name name)
        {
            return View("DisplayColor", name);
        }
    }
}