using System;
using System.Web.Mvc;
using System.Web.Security;

namespace mweb
{
	public class RequiresAuthenticationAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting (ActionExecutingContext filterContext)
		{
			// redirect if not authenticated
			if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
			{
				// use the current url for the redirect
				string redirectOnSuccess = filterContext.HttpContext.Request.Url.AbsolutePath;
				
				// send them of to some page
				string redirectUrl = String.Format("?ReturnUrl={0}", redirectOnSuccess);
				string loginUrl = FormsAuthentication.LoginUrl + redirectUrl;
				filterContext.HttpContext.Response.Redirect(loginUrl, true);
			}
		}
	}
}

