
namespace CMSWeb.Controllers.Admin
{
	using System.Web.Mvc;
	
	using CMSWeb.Attributes;
	using CMSWeb.Models;
	
	public class ConfigurationController : BaseController
	{
		private IDocumentRepository _documentRepository;
		private IStructureRepository _structureRepository;
		private IDocument _document;
		private IUser _user;
		private IStructure _structure;
		
		public ConfigurationController (IDocumentRepository documentRepository,
		                                IStructureRepository structureRepository)
			: base(true)
		{
			_documentRepository = documentRepository;
			_structureRepository = structureRepository;
			
			_document = new Document(_documentRepository);
			_structure = new Structure(_structureRepository);
			
			_user = new User();
		}
		
		[Authorize(Roles = "Admin")]
		public ActionResult Index()
		{
			return View();
		}
				
		[Authorize]
		[ActionName("Configure")]
        [AcceptVerbs(HttpVerbs.Post)]
		[AcceptParameter(Name="Button", Value="Reset Documents")]
        public ActionResult ResetDocuments()
        {
			// remove document data
			_document.DeleteAll();
			
			ViewData["Message"] = "All document data reset";
			return View();
		}
				
		[Authorize(Roles = "Admin")]
		[ActionName("Configure")]
        [AcceptVerbs(HttpVerbs.Post)]
		[AcceptParameter(Name="Button", Value="Reset Structure")]
        public ActionResult ResetStructure()
        {
			// remove structure data
			_structure.DeleteAll();
			
			ViewData["Message"] = "All structure data reset";
			return View();
		}
				
		[Authorize]
		[ActionName("Configure")]
        [AcceptVerbs(HttpVerbs.Post)]
		[AcceptParameter(Name="Button", Value="Reset Users")]
        public ActionResult ResetUsers()
        {
			// remove non admin users
			_user.DeleteAll("User");
			
			ViewData["Message"] = "All user data reset, except admin users";
			return View();
		}
		
	}
}

