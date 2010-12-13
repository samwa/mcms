using System;
using System.Collections.Generic;

using CMSCore.Repositories;
using CMSCore.Entities;

namespace CMSCore.Services
{
	public class DocumentService : IDocumentService
	{
		IDocumentRepository _documentRepository = null;
		
		public DocumentService (IDocumentRepository documentRepository)
		{
			_documentRepository = documentRepository;
		}	

		#region IDocumentService implementation
		public Document LoadDocument (int DocumentId)
		{
			throw new NotImplementedException ();
		}

		public IList<Document> ListDocuments ()
		{
			throw new NotImplementedException ();
		}

		public Document AddDocument (Document document)
		{
			throw new NotImplementedException ();
		}

		public Document UpdateDocument (Document document)
		{
			throw new NotImplementedException ();
		}

		public bool DeleteDocument (Document document)
		{
			throw new NotImplementedException ();
		}
		#endregion
}
}

