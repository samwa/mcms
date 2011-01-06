using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using CMSWeb.Models;

namespace CMSWeb.Controllers
{
	public class DocumentController : BaseController
	{
		IDocumentRepository _documentRepository = null;
		
		public DocumentController(IDocumentRepository documentRepository)
			: base(false)
		{
			_documentRepository = documentRepository;
		}
	}
}

