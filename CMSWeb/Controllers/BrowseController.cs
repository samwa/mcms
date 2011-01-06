using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using CMSWeb.Models;

namespace CMSWeb.Controllers
{
	public class BrowseController : BaseController
	{
		IStructureRepository _structureRepository = null;
		IDocumentRepository _documentRepository = null;
		
		public BrowseController (IStructureRepository structureRepository, IDocumentRepository documentRepository)
			: base(false)
		{
			_structureRepository = structureRepository;
			_documentRepository = documentRepository;
			
		}
		
		public ActionResult Index(int structureId)
		{
			Structure structure = _structureRepository.LoadStructure(structureId);
			return View(structure);
		}
		
		[Authorize]
		public ActionResult Edit(int structureId)
		{
			Structure structure = _structureRepository.LoadStructure(structureId);
			Document document = _documentRepository.LoadDocumentByStructure(structureId);
			ViewData["Document"] = (document ?? new Document{});
			return View(structure);
		}
		
        [AcceptVerbs(HttpVerbs.Post)]
		[ValidateInput(false)]
        public ActionResult Edit(int structureId, string documentData, string documentName)
        {
			// update or create document
			Document document = _documentRepository.LoadDocumentByStructure(structureId);
			
			if (document == null)
				document = _documentRepository.AddDocument(new Document { 
					DocumentID = null, 
					DocumentData = documentData, 
					DocumentName = documentName});
			else
				_documentRepository.UpdateDocument(new Document {
					DocumentID = document.DocumentID,
					DocumentData = documentData,
					DocumentName = documentName,
					Status = Status.Pending });
			
			// update structure
			Structure structure = _structureRepository.LoadStructure(structureId);
			structure.StructureDocumentID = document.DocumentID;
			_structureRepository.UpdateStructure(structure);
			return RedirectToAction("Index", new { StructureID = structureId });
			
        }
		
	}
}

