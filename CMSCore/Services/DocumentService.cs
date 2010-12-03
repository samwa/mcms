using System;

using CMSCore.Repositories;

namespace CMSCore.Services
{
	public class DocumentService : IDocumentService
	{
		IDocumentRepository _documentRepository = null;
		
		public DocumentService (IDocumentRepository documentRepository)
		{
			_documentRepository = documentRepository;
		}
	}
}

