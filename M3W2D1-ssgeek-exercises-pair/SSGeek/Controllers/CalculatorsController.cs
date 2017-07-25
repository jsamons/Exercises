using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class CalculatorsController : Controller
    {
        // INSTRUCTIONS
        // As a part of each exercise you will need to 
        // - develop a view for AlienAge, AlienWeight, and AlienTravel that displays a form to submit data
        // - develop a model for the forms to bind to when the form request is submitted
        // - create a new action to process the form submission (e.g. AlienAgeResult, AlienWeightResult, etc.)
        // - create a view that displays the submitted form result

        // GET: Calculators/AlienAge
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult AlienAge()
        {            
            return View("AlienAge");
        }

        public ActionResult AlienAgeResult(AlienAgeModel model)
        {
            model.AlienAge = model.CalculateAlienAge();
            return View("AlienAgeResult", model);
        }
        
        //TODO: Create an AlienWeight and AlienWeightResult Action
        //TODO: Create an AlienTravel and AlienTravelResult Action

        public ActionResult AlienWeight()
        {
            return View("AlienWeight");
        }
        public ActionResult AlienWeightResult(AlienWeightModel model)
        {
            model.AlienWeight = model.CalculateAlienWeight();
            return View("AlienWeightResult", model);
        }
        public ActionResult AlienTravel()
        {
            return View("AlienTravel");
        }
        public ActionResult AlienTravelResult(AlienTravelModel model)
        {
            return View("AlienTravelResult", model);
        }
    }
}