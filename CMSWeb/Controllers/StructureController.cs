using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CMSWeb.Controllers
{
	[HandleError]
	public class Structure : BaseController
	{
		public Structure ()
		{
			
		}
		public ActionResult Index ()
		{
			ViewData["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View ();
		}
		
		public ActionResult List()
		{
			return 
		}		
	}
}

