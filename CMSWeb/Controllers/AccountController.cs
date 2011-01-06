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
			: base(false)
		{
			_userRepository = userRepository;
		}
		
		public void Index()
		{
			
		}
		
		public ActionResult Login()
		{
			return View();
		}
		
		public ActionResult Register()
		{
			return View();
		}
		
        [AcceptVerbs(HttpVerbs.Post)]
		[ValidateInput(false)]
        public ActionResult Register(string username, string password, string confirmPassword, string email)
        {
			if (password == confirmPassword)
			{
				System.Web.Security.Membership.CreateUser(username, password, email);	
				
				FormsAuthentication.SetAuthCookie(username, true);
				return RedirectToAction("Index", "Home");
			}
			
			return RedirectToAction("Index");			
		}
		
		public ActionResult DoLogin(string username, string password)
		{
			if (System.Web.Security.Membership.ValidateUser(username, password))
			{
				FormsAuthentication.SetAuthCookie(username, true);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				TempData["LoginMessage"] = "The username and password supplied are not valid";
				return RedirectToAction("Login");
			}
		}		
		
		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
	}
}