using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CMSWeb.Controllers
{
	[HandleError]
	public class HomeController : BaseController
	{
		public ActionResult Index ()
		{
			ViewData["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View ();
		}
		
		public string GetStatus()
		{
			return "Status OK at " + DateTime.Now.ToLongTimeString();
		}
		
		public string UpdateForm(string textBox1)
		{
			if (textBox1 != "Enter text")
			{
				return "You entered: \"" + textBox1.ToString() + "\" at " + 
					DateTime.Now.ToLongTimeString();
			}
			
			return String.Empty;
		}
	}
}

