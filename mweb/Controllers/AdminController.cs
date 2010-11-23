using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace mweb
{
	public class AdminController : Controller
	{
		[Authorize(Roles = "Admin")]
		public void Index()
		{
			//ViewResult("Index");
			View();
		}
		
	}
}

