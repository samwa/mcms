using System;
using System.Web.Mvc;
using System.Web.Security;

namespace mweb
{
	/// <summary>
	/// Checks the Users role using FormsAuthentication
	/// and throws and UnauthorizedAccessException if not authorised
	/// </summary>
	public class RequiresRoleAttribute : ActionFilterAttribute
	{
		public string RoleToCheckFor { get; set; }
		
		public override void OnActionExecuting (ActionExecutingContext filterContext)
		{
			// redirect if the user is not authenticated
			if (!String.IsNullOrEmpty(RoleToCheckFor))
			{
				if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
				{
					//use the current url for the redirect
					string redirectOnSuccess = filterContext.HttpContext.Request.Url.AbsolutePath;
										
                    //send them off to the login page
                    string redirectUrl = string.Format("?ReturnUrl={0}", redirectOnSuccess);
                    string loginUrl = FormsAuthentication.LoginUrl + redirectUrl;
                    filterContext.HttpContext.Response.Redirect(loginUrl, true);
				}
				else
				{
					bool isAuthorised = filterContext.HttpContext.User.IsInRole(RoleToCheckFor);
					if (!isAuthorised)
						throw new UnauthorizedAccessException("You are not authorised to view this page");
				
				}		
			}
			else
			{
				throw new InvalidOperationException("No Role Specified");
			}		
		}
	} 
}