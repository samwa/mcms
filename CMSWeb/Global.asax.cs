using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Routing;

namespace CMSWeb
{
	public class MvcApplication : System.Web.HttpApplication
	{
		private CMSContainer container;
		
//		public static void RegisterRoutes (RouteCollection routes)
//		{
//			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");
//			
//			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });
//			
//		}
		
		protected void Application_Start ()
		{
			container = new CMSContainer();
			container.InstallComponents();	
			
			
			//container.RegisterType<IUserRepository>(new InjectionMember(UserRepository));
			//RegisterRoutes (RouteTable.Routes);
			
			RoutingRules.Configure(RouteTable.Routes);
		}
	}
}

