using System;
using System.Web.Routing;
using System.Web.Mvc;

namespace CMSWeb
{
	public class RoutingRules
	{
		public static void Configure(RouteCollection routes)
		{			
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");			
			
			routes.MapRoute("Admin", "Admin/{controller}/{action}/{id}", new { controller = "Admin", action = "Index", id = "" });
			
			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
		}
	}
}

