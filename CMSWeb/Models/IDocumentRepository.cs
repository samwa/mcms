
namespace CMSWeb.Models
{
	using System;
	using System.Collections.Generic;

	public interface IDocumentRepository
	{
		Document LoadDocument(int DocumentId);
		IList<Document> ListDocuments();
		
		Document AddDocument(Document document);
		Document UpdateDocument(Document document);
		bool DeleteDocument(Document document);
	}
}

