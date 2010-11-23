using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Microsoft.Practices.Unity;

namespace mweb
{
	public class MvcApplication : System.Web.HttpApplication
	{
		private IUnityContainer container;
		
		public static void RegisterRoutes (RouteCollection routes)
		{
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute ("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
			
		}

		protected void Application_Start ()
		{
			container = new UnityContainer();
			RegisterRoutes (RouteTable.Routes);
		}
	}
}

