using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace CMSWeb.HtmlHelpers
{
	public static class HtmlHelpers
	{
		
		public static string MenuItem(this HtmlHelper helper, string linkText, string actionName, string controllerName)
		{
			string currentControllerName = (string)helper.ViewContext.RouteData.Values["controller"];
			string currentActionName = (string)helper.ViewContext.RouteData.Values["action"];
			
			TagBuilder builder = new TagBuilder("li");
			
			builder.InnerHtml = helper.ActionLink(linkText, actionName, controllerName);
			// add selected class
			if (currentControllerName == controllerName 
			    && currentActionName == actionName)
				builder.AddCssClass("selected");
				        
			// add link
			return builder.ToString(TagRenderMode.Normal);			
		}
	}
}