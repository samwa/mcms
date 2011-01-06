namespace CMSWeb.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	
	public class BaseController : Controller
	{
		bool _isAdmin;
		public BaseController (bool isAdmin)
		{
			_isAdmin = isAdmin;			
			
			ViewData["IsAdmin"] = _isAdmin;
		}
	}
}

