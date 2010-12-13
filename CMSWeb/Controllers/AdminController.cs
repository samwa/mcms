using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using CMSCore.Services;

namespace CMSWeb.Controllers
{
	public class AdminController : BaseController
	{
		IUserService _userService = null;
		
		public AdminController (IUserService userService)
		{
			_userService = userService;
		}
		
		[Authorize(Roles = "Admin")]
		public void Index()
		{
			//ViewResult("Index");
			View();
		}
		
		public ActionResult Structure()
		{
			return View("Structure");
		}
		
		public ActionResult ManageUsers()
		{
			return View("ManageUsers");
		}
		
	}
}