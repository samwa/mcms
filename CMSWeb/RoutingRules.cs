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
			
			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
		}
	}
}
