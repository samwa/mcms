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
		Document _document;
		
		public ApprovalController (IDocumentRepository documentRepository)
			: base(true)
		{
			_documentRepository = documentRepository;		
			_document = new Document(_documentRepository);
		}
		
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }
		
		public ActionResult View(int documentId)
		{
			Document document = _documentRepository.LoadDocument(documentId);
			return View(document);
		}
		
		public ActionResult List()
		{
			IList<Document> documents = _documentRepository.ListDocuments(Enum.GetName(typeof(Status), Status.Review));
			return View(documents);
		}
		
		public ActionResult Approve(int documentId)
		{
			_document = _documentRepository.LoadDocument(documentId);
			_document.Publish();
			return RedirectToAction("List");	
		}
		
		public ActionResult Reject(int documentId)
		{
			_document = _documentRepository.LoadDocument(documentId);
			_document.Reject();
			return RedirectToAction("List");	
		}
	}
}

