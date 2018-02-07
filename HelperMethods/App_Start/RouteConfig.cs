using System.Web.Mvc;
using System.Web.Routing;

namespace HelperMethods
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "MyFormRoute",
                "allforms/{controller}/{action}",
                new { controller = "Home", action = "CreateCustomer" }
            );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "CreateCustomer", id = UrlParameter.Optional}
            );


        }
    }
}