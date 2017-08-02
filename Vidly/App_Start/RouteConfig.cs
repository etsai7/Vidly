using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Equivalent as commented out Route
            routes.MapMvcAttributeRoutes();

            
            // Custon Route the convventional bulky way
            /*
            routes.MapRoute(            // Order of these routes matter.
                "MoviesByReleaseDate",  // Order from most specific to generic
                "movies/release/{year}/{month}",
                new {controller = "Movies", action = "ByReleaseDate"}, //This is an anonymous object
                //new {year = @"\d{4}", month = @"\d{2}"} // the @ sign acts as a backslash for the backslash. Also limits decimal to 4 digits and 2 digits only allowed
                new {year = @"2015|2016", month = @"\d{2}"} // Years must be 2015 or 2016
            ); 
            */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
