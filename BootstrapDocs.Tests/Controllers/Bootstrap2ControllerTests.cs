using System.Web.Mvc;
using BootstrapDocs.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BootstrapDocs.Tests.Controllers
{
    [TestClass()]
    public class Bootstrap2ControllerTests
    {
        [TestMethod()]
        public void BS2_IndexTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_GettingStartedTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.GettingStarted() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_ScaffoldingTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.Scaffolding() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_BaseCSSTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.BaseCSS() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_ComponentsText()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.Components() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_JavaScriptTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.JavaScript() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_CustomizeText()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.Customize() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BS2_ExtendTest()
        {
            var controller = new Bootstrap2Controller();
            var result = controller.Extend() as ViewResult;
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void BS2_ExamplesTest()
        {
            var controller = new Bootstrap2Controller();
            var starter = "starter-template";
            var hero = "hero";
            var fluid = "fluid";
            var marketing = "marketing-narrow";
            var justified = "justified-nav";
            var signin = "signin";
            var sticky = "sticky-footer";
            var carousel = "carousel";

            var starterResult = controller.Examples(starter) as ViewResult;
            Assert.AreEqual("StarterTemplate", starterResult.ViewName);

            var heroResult = controller.Examples(hero) as ViewResult;
            Assert.AreEqual("Hero", heroResult.ViewName);

            var fluidResult = controller.Examples(fluid) as ViewResult;
            Assert.AreEqual("Fluid", fluidResult.ViewName);

            var marketingResult = controller.Examples(marketing) as ViewResult;
            Assert.AreEqual("MarketingNarrow", marketingResult.ViewName);

            var justifiedResult = controller.Examples(justified) as ViewResult;
            Assert.AreEqual("JustifiedNav", justifiedResult.ViewName);

            var signinResult = controller.Examples(signin) as ViewResult;
            Assert.AreEqual("Signin", signinResult.ViewName);

            var stickyResult = controller.Examples(sticky) as ViewResult;
            Assert.AreEqual("StickyFooter", stickyResult.ViewName);

            var carouselResult = controller.Examples(carousel) as ViewResult;
            Assert.AreEqual("Carousel", carouselResult.ViewName);
        }

        [TestMethod()]
        public void BS2_Examples_DefaultTest()
        {
            var controller = new Bootstrap2Controller();

            string errorString = "your-are-best.";
            var starterResult = controller.Examples(errorString) as ViewResult;
            Assert.IsNotNull(starterResult);
            Assert.AreEqual("StarterTemplate", starterResult.ViewName);

        }
    }
}
