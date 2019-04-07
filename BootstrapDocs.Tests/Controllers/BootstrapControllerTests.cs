using System.Web.Mvc;
using BootstrapDocs.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BootstrapDocs.Tests.Controllers
{
    [TestClass()]
    public class BootstrapControllerTests
    {
        [TestMethod()]
        public void Bootstrap_Index_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.Index() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("index", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_GettingStarted_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.GettingStarted() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("GettingStarted", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_Scaffolding_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.Scaffolding() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("Scaffolding", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_BaseCSS_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.BaseCSS() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("BaseCSS", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_Components_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.Components() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("Components", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_JavaScript_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.JavaScript() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("JavaScript", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_Customize_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.Customize() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("Customize", result.RouteValues["action"]);
        }

        [TestMethod()]
        public void Bootstrap_Extend_Redirect301_Bootstrap2Test()
        {
            var controller = new BootstrapController();
            var result = controller.Extend() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("BS2", result.RouteName);
            Assert.AreEqual("Extend", result.RouteValues["action"]);
        }
    }
}