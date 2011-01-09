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
		private IStructureRepository _structureRepository;
		private IDocumentRepository _documentRepository;
		private IStructureRepository _structureDocumentRepository;
		
		private Document _document;
		
		public BrowseController (IStructureRepository structureRepository, 
		                         IDocumentRepository documentRepository)
			: base(false)
		{
			_structureRepository = structureRepository;
			_documentRepository = documentRepository;
			
			_document = new Document(_documentRepository);	
		}
		
		public ActionResult Index(int structureId)
		{
			Structure structure = _structureRepository.LoadStructure(structureId);
			
			_document = _document.Load(structure.StructureID, Status.Live);
			
			ViewData["Document"] = (_document ?? new Document{});
			return View(structure);
		}
		
		[Authorize]
		public ActionResult Edit(int structureId)
		{		
			Structure structure = _structureRepository.LoadStructure(structureId);
			
			_document = _document.Load(structure.StructureID);
			
			ViewData["Document"] = (_document ?? new Document{});
			Status status = Status.Review;
			ViewData["Status"] = Enum.GetName(typeof(Status), status);
			ViewData["StatusList"] = new List<string>(new string [] { "Review", "Live" });
			return View(structure);
		}
		
        [AcceptVerbs(HttpVerbs.Post)]
		[ValidateInput(false)]
        public ActionResult Edit(int structureId, string documentData, string documentName)
        {
			// update or create document
			// get review doc
			_document = _documentRepository.LoadDocumentByStructure(structureId, _document.StatusToString(Status.Review));
			
			// no review doc so get live
			if (_document == null)
				_document = _documentRepository.LoadDocumentByStructure(structureId);
			
			if (_document == null)
			{
				// no live or review doc, create a new one
				_document = new Document { 
					DocumentData = documentData, 
					DocumentName = documentName,
					Status = Status.Review};
				_document = _document.Add(_document);
			}
			else
			{
				Document newDocument = new Document { 
					DocumentID = null,
					DocumentRootID = _document.DocumentRootID,
					DocumentData = documentData, 
					DocumentName = documentName,
					Status = Status.Review };
				
				_document = _document.Update(newDocument);
			}
			
			// update structure
			Structure structure = _structureRepository.LoadStructure(structureId);
			structure.StructureDocumentID = _document.DocumentRootID;
			_structureRepository.UpdateStructure(structure);
						
			return RedirectToAction("Index", new { StructureID = structureId });			
        }
		
	}
}

