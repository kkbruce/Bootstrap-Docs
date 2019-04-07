using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BootstrapDocs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BS3",
                url: "bs3/{action}/{name}",
                defaults: new
                {
                    controller = "Bootstrap3",
                    action = "Index",
                    name = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "BS2",
                url: "bs2/{action}",
                defaults: new
                {
                    controller = "Bootstrap2",
                    action = "Index",
                }
            );

            routes.MapRoute(
                name: "ShortHome",
                url: "{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                constraints: new { action = "(Index)" },
                namespaces: new[] { "BootstrapDocs.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
