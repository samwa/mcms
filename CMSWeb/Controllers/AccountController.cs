namespace CMSWeb.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	using System.Web.Security;
	
	using CMSWeb.Models;
	
	public class AccountController : BaseController
	{
		IUserRepository _userRepository = null;
		IUser _user;
		
		public AccountController (IUserRepository userRepository)
			: base(false)
		{
			_userRepository = userRepository;
			_user = new User(_userRepository);
		}
		
		public void Index()
		{
			
		}
		
		public ActionResult CheckLogin()
		{
			if (User.Identity.IsAuthenticated)
				return RedirectToAction("NeedsRole");
			else
				return RedirectToAction("Login");
		}
		
		public ActionResult NeedsRole()
		{
			return View();
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
				Roles.AddUserToRole(username, EnumHelper.EnumToString<UserRole>(UserRole.User));
				
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