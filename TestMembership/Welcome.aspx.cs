
using System;
using System.Web;
using System.Web.UI;

namespace TestMembership
{


	public partial class Welcome : System.Web.UI.Page
	{
	    protected void Page_Load(object sender, EventArgs e)
	    {
	        if(Page.User.Identity!=null)
	        this.Label1.Text = "Welcome," + Page.User.Identity.Name + "!";
	
	    }
	}
}

