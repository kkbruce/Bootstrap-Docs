using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDocs.Controllers
{
    public class Bootstrap3Controller : Controller
    {
        // GET: Bootstrap3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GettingStarted()
        {
            return View();
        }

        public ActionResult CSS()
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

        public ActionResult Migration()
        {
            return View();
        }

        public ActionResult BrowserBugs()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Examples(string name)
        {
            string ViewName = string.Format("Examples/{0}/Index", name);
            return View(ViewName);
        }
    }
}