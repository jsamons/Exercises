using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class CigarPartyController : Controller
    {
        // GET: CigarParty
        public ActionResult Index()
        {
            return View("CigarParty");
        }
        public ActionResult CigarParty()
        {
            return View();
        }
        public ActionResult CigarPartyResult(CigarParty party)
        {
            bool goodParty = false;
            if(party.IsWeekend)
            {
                if(party.NumOfSquirrels>=40)
                {
                    goodParty = true;
                }
            }
            else
            {
                if(party.NumOfSquirrels>=40 && party.NumOfSquirrels<=60)
                {
                    goodParty = true;
                }
            }
            return View(goodParty);
        }
    }
}