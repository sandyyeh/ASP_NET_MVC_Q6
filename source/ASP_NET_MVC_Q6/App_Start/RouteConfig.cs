using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Home_Welcome",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional },
            constraints: new { Controller = "Home", action = "Welcome" }
            );

            routes.MapRoute(
               name: "/Contact",
               url: "Contact/{id}",
               defaults: new { controller = "Home", action = "ContactMe", id = UrlParameter.Optional },
                 constraints: new { Controller = "Home", action = "ContactMe" }
            );


            routes.MapRoute(
            name: "Default2",
            url: "{action}/{id}",
            defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "ASP_NET_MVC_Q6.Controllers" }
        );



        }
    }
}
