using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //To create attribute[Route] in the controller
            //routes.MapMvcAttributeRoutes();


            // order of route is important. It takes from more specific to more generic
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/release/{year}/{month}",
            //    new { controller = "Movies", action= "ByReleaseDate"},
            //    new { year = @"2015|2016", month = @"\d{2}"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
