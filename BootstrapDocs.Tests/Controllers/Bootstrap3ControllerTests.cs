using System.Web.Mvc;
using BootstrapDocs.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BootstrapDocs.Tests.Controllers
{
    [TestClass()]
    public class Bootstrap3ControllerTests
    {
        [TestMethod()]
        public void BS3_IndexTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_GettingStartedTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.GettingStarted() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_CSSTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.CSS() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_ComponentsTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.Components() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_JavaScriptTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.JavaScript() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_MigrationTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.Migration() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_AboutTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_BrowserBugsTest()
        {
            var controller = new Bootstrap3Controller();
            var result = controller.BrowserBugs() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void BS3_ExamplesTest()
        {
            var controller = new Bootstrap3Controller();

            string starter = "starter-template";
            string ViewName = string.Format("Examples/{0}/Index", starter);
            var starterResult = controller.Examples(starter) as ViewResult;
            Assert.IsNotNull(starterResult);
            Assert.AreEqual(ViewName, starterResult.ViewName);

            string theme = "theme";
            ViewName = string.Format("Examples/{0}/Index", theme);
            var ThemeResult = controller.Examples(theme) as ViewResult;
            Assert.IsNotNull(ThemeResult);
            Assert.AreEqual(ViewName, ThemeResult.ViewName);

            string grid = "grid";
            ViewName = string.Format("Examples/{0}/Index", grid);
            var gridResult = controller.Examples(grid) as ViewResult;
            Assert.IsNotNull(gridResult);
            Assert.AreEqual(ViewName, gridResult.ViewName);

            string jumbotron = "jumbotron";
            ViewName = string.Format("Examples/{0}/Index", jumbotron);
            var jumbotronResult = controller.Examples(jumbotron) as ViewResult;
            Assert.IsNotNull(jumbotronResult);
            Assert.AreEqual(ViewName, jumbotronResult.ViewName);

            string jumbotronNarrow = "jumbotron-narrow";
            ViewName = string.Format("Examples/{0}/Index", jumbotronNarrow);
            var jumbotronNarrowResult = controller.Examples(jumbotronNarrow) as ViewResult;
            Assert.IsNotNull(jumbotronNarrowResult);
            Assert.AreEqual(ViewName, jumbotronNarrowResult.ViewName);

            string navbar = "navbar";
            ViewName = string.Format("Examples/{0}/Index", navbar);
            var navbarResult = controller.Examples(navbar) as ViewResult;
            Assert.IsNotNull(navbarResult);
            Assert.AreEqual(ViewName, navbarResult.ViewName);

            string navbarStaticTop = "navbar-static-top";
            ViewName = string.Format("Examples/{0}/Index", navbarStaticTop);
            var navbarStaticTopResult = controller.Examples(navbarStaticTop) as ViewResult;
            Assert.IsNotNull(navbarStaticTopResult);
            Assert.AreEqual(ViewName, navbarStaticTopResult.ViewName);

            string navbarFixedTop = "navbar-fixed-top";
            ViewName = string.Format("Examples/{0}/Index", navbarFixedTop);
            var navbarFixedTopResult = controller.Examples(navbarFixedTop) as ViewResult;
            Assert.IsNotNull(navbarFixedTopResult);
            Assert.AreEqual(ViewName, navbarFixedTopResult.ViewName);

            string cover = "cover";
            ViewName = string.Format("Examples/{0}/Index", cover);
            var coverResult = controller.Examples(cover) as ViewResult;
            Assert.IsNotNull(coverResult);
            Assert.AreEqual(ViewName, coverResult.ViewName);

            string carousel = "carousel";
            ViewName = string.Format("Examples/{0}/Index", carousel);
            var carouselResult = controller.Examples(carousel) as ViewResult;
            Assert.IsNotNull(carouselResult);
            Assert.AreEqual(ViewName, carouselResult.ViewName);

            string blog = "blog";
            ViewName = string.Format("Examples/{0}/Index", blog);
            var blogResult = controller.Examples(blog) as ViewResult;
            Assert.IsNotNull(blogResult);
            Assert.AreEqual(ViewName, blogResult.ViewName);

            string dashboard = "dashboard";
            ViewName = string.Format("Examples/{0}/Index", dashboard);
            var dashboardResult = controller.Examples(dashboard) as ViewResult;
            Assert.IsNotNull(dashboardResult);
            Assert.AreEqual(ViewName, dashboardResult.ViewName);

            string signin = "signin";
            ViewName = string.Format("Examples/{0}/Index", signin);
            var signinResult = controller.Examples(signin) as ViewResult;
            Assert.IsNotNull(signinResult);
            Assert.AreEqual(ViewName, signinResult.ViewName);

            string justifiedNav = "justified-nav";
            ViewName = string.Format("Examples/{0}/Index", justifiedNav);
            var justifiedNavResult = controller.Examples(justifiedNav) as ViewResult;
            Assert.IsNotNull(justifiedNavResult);
            Assert.AreEqual(ViewName, justifiedNavResult.ViewName);

            string stickyFooter = "sticky-footer";
            ViewName = string.Format("Examples/{0}/Index", stickyFooter);
            var stickyFooterResult = controller.Examples(stickyFooter) as ViewResult;
            Assert.IsNotNull(stickyFooterResult);
            Assert.AreEqual(ViewName, stickyFooterResult.ViewName);

            string stickyFooterNavbar = "sticky-footer-navbar";
            ViewName = string.Format("Examples/{0}/Index", stickyFooterNavbar);
            var stickyFooterNavbarResult = controller.Examples(stickyFooterNavbar) as ViewResult;
            Assert.IsNotNull(stickyFooterNavbarResult);
            Assert.AreEqual(ViewName, stickyFooterNavbarResult.ViewName);

            string nonResponsive = "non-responsive";
            ViewName = string.Format("Examples/{0}/Index", nonResponsive);
            var nonResponsiveResult = controller.Examples(nonResponsive) as ViewResult;
            Assert.IsNotNull(nonResponsiveResult);
            Assert.AreEqual(ViewName, nonResponsiveResult.ViewName);

            string offcanvas = "offcanvas";
            ViewName = string.Format("Examples/{0}/Index", offcanvas);
            var offcanvasResult = controller.Examples(offcanvas) as ViewResult;
            Assert.IsNotNull(offcanvasResult);
            Assert.AreEqual(ViewName, offcanvasResult.ViewName);
        }
    }
}
