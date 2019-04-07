using System.Web.Mvc;

namespace BootstrapDocs.Controllers
{
    /// <summary>
    /// 網站改版，相容舊路由。
    /// </summary>
    public class BootstrapV3Controller : Controller
    {
        public ActionResult Index()
        {
            return RedirectToRoutePermanent("BS3", new { action = "index" });
        }

        public ActionResult GettingStarted()
        {
            return RedirectToRoutePermanent("BS3", new { action = "GettingStarted" });
        }

        public ActionResult CSS()
        {
            return RedirectToRoutePermanent("BS3", new { action = "CSS" });
        }

        public ActionResult Components()
        {
            return RedirectToRoutePermanent("BS3", new { action = "Components" });
        }

        public ActionResult JavaScript()
        {
            return RedirectToRoutePermanent("BS3", new { action = "JavaScript" });
        }

        public ActionResult Customize()
        {
            return RedirectToRoutePermanent("BS3", new { action = "Customize" });
        }
    }
}