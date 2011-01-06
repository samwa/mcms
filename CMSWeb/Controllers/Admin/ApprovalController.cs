namespace CMSWeb.Controllers.Admin
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	
	using CMSWeb.Models;
	
	public class ApprovalController : BaseController
	{
		IDocumentRepository _documentRepository = null;
		
		public ApprovalController (IDocumentRepository documentRepository)
			: base(true)
		{
			_documentRepository = documentRepository;
			
		}
		
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }
		
		public ActionResult List()
		{
			IList<Document> documents = _documentRepository.ListDocuments("pending");
			return View(documents);
		}
	}
}

