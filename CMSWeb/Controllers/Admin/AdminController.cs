using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using CMSWeb.Models;

namespace CMSWeb.Controllers.Admin
{
	public class AdminController : BaseController
	{
		IUserRepository _userRepository = null;
		
		public AdminController (IUserRepository userRepository)
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