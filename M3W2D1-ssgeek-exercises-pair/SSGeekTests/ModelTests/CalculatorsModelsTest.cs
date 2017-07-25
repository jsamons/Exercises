using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System.Web.Mvc;


namespace SSGeekTests.ModelTests
{
    [TestClass]
    public class CalculatorsModelsTest
    {
        [TestMethod]
        public void CalculateAgeTest()
        {
            AlienAgeModel model = new AlienAgeModel();
            model.Age = 5;
            model.PlanetFactor = "Mercury:4.15";
            double alienAge = model.CalculateAlienAge();
            Assert.AreEqual(20.75, alienAge);
        }

        [TestMethod]
        public void CalculateWeightTest()
        {
            AlienWeightModel model = new AlienWeightModel();
            model.EarthWeight = 100;
            model.GravityFactor = "Mercury:0.37";
            double alienWeight = model.CalculateAlienWeight();
            Assert.AreEqual(37, alienWeight);
        }

        [TestMethod]
        public void CalculateTravelTest()
        {
            AlienTravelModel model = new AlienTravelModel();
            model.Age = 100;
            model.PlanetHolder = "Mercury:56974146";
            model.TransportHolder = "Car:100";

            double yearsTraveled = model.CalculateYearsTraveled();
            Assert.AreEqual(65.04, Math.Round(yearsTraveled, 2));
        }
    }
}
