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
			
			routes.MapRoute("Admin", "Admin/Structure/{action}/{id}", 
			                new { controller = "Structure", action = "Index", id = "" });
			
			routes.MapRoute("Browse", "Browse/{action}/{StructureId}", 
			                new { controller = "Browse", action = "Index", id = "" });
						
			routes.MapRoute("Home", "{controller}/{action}/{id}", 
			                new { controller = "Home", action = "Index", id = "" });
		}
	}
}

