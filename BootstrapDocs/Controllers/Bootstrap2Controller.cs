using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDocs.Controllers
{
    public class Bootstrap2Controller : Controller
    {
        // GET: Bootstrap2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GettingStarted()
        {
            return View();
        }

        public ActionResult Scaffolding()
        {
            return View();
        }

        public ActionResult BaseCSS()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }

        public ActionResult JavaScript()
        {
            return View();
        }

        public ActionResult Customize()
        {
            return View();
        }

        /// <summary>
        /// 未翻譯。
        /// </summary>
        public ActionResult Extend()
        {
            return View();
        }

        public ActionResult Examples(string name)
        {
            switch (name)
            {
                case "starter-template":
                    return View("StarterTemplate");
                case "hero":
                    return View("Hero");
                case "fluid":
                    return View("Fluid");
                case "marketing-narrow":
                    return View("MarketingNarrow");
                case "justified-nav":
                    return View("JustifiedNav");
                case "signin":
                    return View("Signin");
                case "sticky-footer":
                    return View("StickyFooter");
                case "carousel":
                    return View("Carousel");
            }

            return View("StarterTemplate");
        }
    }
}