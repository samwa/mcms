using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Security;

using CMSWeb.Models;

namespace CMSWeb.Controllers
{
	public class AccountController : BaseController
	{
		IUserRepository _userRepository = null;
		
		public AccountController (IUserRepository userRepository)
		{
			_userRepository = userRepository;
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