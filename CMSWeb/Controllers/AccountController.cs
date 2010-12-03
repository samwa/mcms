using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Security;

using CMSCore.Services;

namespace CMSWeb.Controllers
{
	public class AccountController : BaseController
	{
		IUserService _userService = null;
		
		public AccountController (IUserService userService)
		{
			_userService = userService;
		}
		
		public void Index()
		{
			
		}
		
		public ActionResult Login()
		{
			return View ();
		}
		
		public void DoLogin(string username, string password)
		{
			if (System.Web.Security.Membership.ValidateUser(username, password))
			{
				FormsAuthentication.SetAuthCookie(username, true);
				RedirectToAction("Index", "Home");
			}
			else
			{
				TempData["LoginMessage"] = "The username and password supplied are not valid";
				RedirectToAction("Index");
			}
		}		
	}
}