namespace CMSWeb.Controllers.Admin
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	
	using CMSWeb.Models;
	
	public class UserManagerController : BaseController
	{
		IUserRepository _userRepository = null;
		
		public UserManagerController (IUserRepository userRepository)
			: base(true)
		{
			_userRepository = userRepository;
		}
		
		[Authorize(Roles = "Admin")]
		public void Index()
		{
			View();
		}
		
		
		public ActionResult ManageUsers()
		{
			return View("ManageUsers");
		}
		
	}
}