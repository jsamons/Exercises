using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System.Web.Mvc;

namespace SSGeekTests.Controllers
{
    [TestClass]
    public class PlanetsControllerTest
    {
        [TestMethod()]
        public void IndexTest()
        {
            PlanetsController controller = new PlanetsController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod()]
        public void TriviaQuestionTest()
        {
            PlanetsController controller = new PlanetsController();

            ViewResult result = controller.TriviaQuestion() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("TriviaQuestion", result.ViewName);
        }

        [TestMethod()]
        public void TriviaQuestionResultTest()
        {
            PlanetsController controller = new PlanetsController();
            TriviaModel model = new TriviaModel();
            model.Name = "Buzz Aldrin";
            model.SubmittedAnswer = "Neil Armstrong";
            

            RedirectToRouteResult result = controller.TriviaQuestionResult(model) as RedirectToRouteResult;

            
            Assert.AreEqual("TriviaQuestionCorrect", result.RouteValues["action"]);
            model.SubmittedAnswer = "WRONG";

            RedirectToRouteResult result2 = controller.TriviaQuestionResult(model) as RedirectToRouteResult;

            Assert.AreEqual("TriviaQuestionWrong", result2.RouteValues["action"]);
        }


    }
}
