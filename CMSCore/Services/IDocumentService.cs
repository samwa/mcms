using System;
using System.Collections.Generic;

using CMSCore.Entities;

namespace CMSCore.Services
{
	public interface IDocumentService
	{
		
		Document LoadDocument(int DocumentId);
		IList<Document> ListDocuments();
		
		Document AddDocument(Document document);
		Document UpdateDocument(Document document);
		bool DeleteDocument(Document document);		
	}
}

