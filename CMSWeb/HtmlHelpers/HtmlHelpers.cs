using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace CMSWeb.HtmlHelpers
{
	public static class HtmlHelpers
	{
		
		public static string MenuItem(this HtmlHelper helper, string linkText, string actionName, string controllerName)
		{
			return MenuItem(helper, linkText, actionName, controllerName, String.Empty);
		}
		
		public static string MenuItem(this HtmlHelper helper, string linkText, string actionName, string controllerName, string area)
		{
			
			return MenuItem(helper, linkText, actionName, controllerName, area, new {});
		}
		
		public static string MenuItem(this HtmlHelper helper, string linkText, string actionName, string controllerName, string area, object routeValues)
		{
			string currentControllerName = (string)helper.ViewContext.RouteData.Values["controller"];
			string currentActionName = (string)helper.ViewContext.RouteData.Values["action"];
			
			TagBuilder builder = new TagBuilder("li");
			
			builder.InnerHtml = helper.ActionLink(linkText, actionName, controllerName, routeValues, new {});
				
			// add selected class
			if (currentControllerName == controllerName 
			    && currentActionName == actionName)
				builder.AddCssClass("selected");
				        
			// add link
			return builder.ToString(TagRenderMode.Normal);			
		}
	}
}