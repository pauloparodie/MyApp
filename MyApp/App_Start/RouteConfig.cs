using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                            name: "Add",
                            url: "Home/Add/{val1}/{val2}",
                            defaults: new { controller = "Home", action = "Add" }
                        );

            /*
            routes.MapRoute(
                name: "Add",
                url: "Home/Add/{val1}/{val2}",
                defaults: new { controller = "Home", action = "Add"}
            );

            routes.MapRoute(
                name: "Multiply",
                url: "Home/Multiply/{multparam}",
                defaults: new { controller = "Home", action = "Multiply", multparam = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
