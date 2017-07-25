using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSGeek.Controllers;
using SSGeek.Models;
using System.Web.Mvc;

namespace SSGeekTests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod()]
        public void IndexTest()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
