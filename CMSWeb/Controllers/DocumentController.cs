using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using CMSCore.Services;

namespace CMSWeb.Controllers
{
	public class DocumentController : BaseController
	{
		IDocumentService _documentService = null;
		
		public DocumentController(IDocumentService documentService)
		{
			_documentService = documentService;
		}
	}
}

