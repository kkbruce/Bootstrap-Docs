using System.Web;
using System.Web.Optimization;

namespace BootstrapDocs
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Bootstrap 2
            bundles.Add(new StyleBundle("~/Content/BS2/css").Include(
                "~/Content/BS2/bootstrap.css",
                "~/Content/BS2/bootstrap-responsive.css",
                "~/Content/BS2/docs.css",
                "~/Scripts/BS2/google-code-prettify/prettify.css"));

            bundles.Add(new ScriptBundle("~/bundles/BS2SourceJS").Include(
                "~/Scripts/BS2/jquery.js",
                "~/Scripts/BS2/bootstrap-transition.js",
                "~/Scripts/BS2/bootstrap-alert.js",
                "~/Scripts/BS2/bootstrap-modal.js",
                "~/Scripts/BS2/bootstrap-dropdown.js",
                "~/Scripts/BS2/bootstrap-scrollspy.js",
                "~/Scripts/BS2/bootstrap-tab.js",
                "~/Scripts/BS2/bootstrap-tooltip.js",
                "~/Scripts/BS2/bootstrap-popover.js",
                "~/Scripts/BS2/bootstrap-button.js",
                "~/Scripts/BS2/bootstrap-collapse.js",
                "~/Scripts/BS2/bootstrap-carousel.js",
                "~/Scripts/BS2/bootstrap-typeahead.js"));

            bundles.Add(new ScriptBundle("~/bundles/BS2JS").Include(
                "~/Scripts/BS2/bootstrap.js",
                "~/Scripts/BS2/holder/holder.js",
                "~/Scripts/BS2/google-code-prettify/prettify.js",
                "~/Scripts/BS2/application.js"));
            #endregion

            #region Bootstrap 3

            bundles.Add(new StyleBundle("~/Content/BS3/DocCss").Include(
                "~/Content/AssetsBS3/src/docs.css",
                "~/Content/AssetsBS3/src/pygments-manni.css",
                "~/Content/AssetsBS3/change-font.css"));

            bundles.Add(new ScriptBundle("~/bundles/IEEmulation").Include(
                "~/Scripts/AssetsBS3/ie-emulation-modes-warning.js"));

            bundles.Add(new ScriptBundle("~/bundles/BS3DocJs").Include(
                "~/Scripts/AssetsBS3/docs.min.js",
                "~/Scripts/AssetsBS3/ie10-viewport-bug-workaround.js"));
            #endregion

            #region Online jQuery
            // Online jQuery
            //BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
            string jqCdnPath = "http://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js";
            bundles.Add(new ScriptBundle("~/bundles/jqueryonline", jqCdnPath).Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/DetectRemotejQuery.js"));
            #endregion
        }
    }
}
