using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class BabyLottoController : Controller
    {
        // GET: BabyLotto
        public ActionResult Index()
        {
            return View("BabyLotto");
        }
        public ActionResult BabyLotto()
        {
            return View();
        }
        public ActionResult BabyLottoResult(List<string> lotto)
        {
            return View(lotto);
        }
    }
}