using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDocs.Controllers
{
    /// <summary>
    /// 網站改版，相容舊路由。
    /// 將舊Url: /Bootstrap 進行 301 重導向
    /// </summary>
    public class BootstrapController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToRoutePermanent("BS2", new { action = "index" });
        }

        public ActionResult GettingStarted()
        {
            return RedirectToRoutePermanent("BS2", new { action = "GettingStarted" });
        }

        public ActionResult Scaffolding()
        {
            return RedirectToRoutePermanent("BS2", new { action = "Scaffolding" });
        }

        public ActionResult BaseCSS()
        {
            return RedirectToRoutePermanent("BS2", new { action = "BaseCSS" });
        }

        public ActionResult Components()
        {
            return RedirectToRoutePermanent("BS2", new { action = "Components" });
        }

        public ActionResult JavaScript()
        {
            return RedirectToRoutePermanent("BS2", new { action = "JavaScript" });
        }

        public ActionResult Customize()
        {
            return RedirectToRoutePermanent("BS2", new { action = "Customize" });
        }

        public ActionResult Extend()
        {
            return RedirectToRoutePermanent("BS2", new { action = "Extend" });
        }
    }
}
