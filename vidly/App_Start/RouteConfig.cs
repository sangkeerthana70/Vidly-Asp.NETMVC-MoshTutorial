using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //define custom routes using attributes for the corresponding action
            routes.MapMvcAttributeRoutes();

            /*
            //define custom routes which is a specific route and has to be defined first
            routes.MapRoute(
                "MoviesByReleaseDate",//name
                "movies/released/{year}/{month}",//url
                 new { controller = "Movies", action = "ByReleaseDate" },//defaults 
                //new { year = @"\d{4}", month = @"\d{2}" });//constraints
                new { year = @"2016|2017", month = @"\d{2}"});//limit route parameters to a few specific values. Here 2016 or 2017 are specific parameters*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
