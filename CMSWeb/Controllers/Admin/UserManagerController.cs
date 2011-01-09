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
		private IUserRepository _userRepository = null;
		private Models.User _user;
		
		public UserManagerController (IUserRepository userRepository)
			: base(true)
		{
			_userRepository = userRepository;
			_user = new Models.User(_userRepository);
		}
		
		[Authorize(Roles = "Admin")]
		public ActionResult Index()
		{
			return RedirectToAction("List");
		}
		
		[Authorize(Roles = "Admin")]
		public ActionResult List()
		{
			List<Models.User> users = new List<Models.User>(_user.List(UserRole.User));
			
			List<UserRole> roles = EnumHelper.EnumToList<UserRole>();
			ViewData["roles"] = roles;
			
			return View(users);
		}		
		
		[Authorize(Roles = "Admin")]
		public ActionResult MakeAdmin(string userName)
		{
			_user = _user.Load(userName);
			_user.AddUserToRole(UserRole.Admin);
			_user.RemoveUserFromRole(UserRole.User);
			
			return RedirectToAction("List");
		}
		
		[Authorize(Roles = "Admin")]	
        [AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Delete(string userName)
		{
			
			
			return RedirectToAction("List");
		}
		
	}
}