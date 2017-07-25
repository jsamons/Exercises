using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System.Web.Mvc;

namespace SSGeekTests.Controllers
{
    [TestClass()]
    public class CalculatorControllerTest
    {
        [TestMethod()]
        public void IndexTest()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod()]
        public void AlienAgeTest()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienAge() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienAge", result.ViewName);
        }

        [TestMethod()]
        public void AlienAgeResultTest()
        {
            CalculatorsController controller = new CalculatorsController();
            AlienAgeModel model = new AlienAgeModel();
            model.PlanetFactor = "Mercury:30";
            ViewResult result = controller.AlienAgeResult(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienAgeResult", result.ViewName);
        }

        [TestMethod()]
        public void AlienTravelTest()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienTravel() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienTravel", result.ViewName);
        }

        [TestMethod()]
        public void AlienTravelResultTest()
        {
            CalculatorsController controller = new CalculatorsController();
            AlienTravelModel model = new AlienTravelModel();
            ViewResult result = controller.AlienTravelResult(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienTravelResult", result.ViewName);
        }

        [TestMethod()]
        public void AlienWeightTest()
        {
            CalculatorsController controller = new CalculatorsController();

            ViewResult result = controller.AlienWeight() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienWeight", result.ViewName);
        }

        [TestMethod()]
        public void AlienWeightResultTest()
        {
            CalculatorsController controller = new CalculatorsController();
            AlienWeightModel model = new AlienWeightModel();
            model.GravityFactor = "mercury:0.37";
            ViewResult result = controller.AlienWeightResult(model) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("AlienWeightResult", result.ViewName);
        }

        



    }
}
