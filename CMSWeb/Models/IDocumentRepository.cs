
namespace CMSWeb.Models
{
	using System;
	using System.Collections.Generic;

	public interface IDocumentRepository
	{
		Document LoadDocument(int documentId);
		Document LoadDocumentByStructure(int structureId);
		IList<Document> ListDocuments();
		IList<Document> ListDocuments(string status);
		
		Document AddDocument(Document document);
		Document UpdateDocument(Document document);
		bool DeleteDocument(Document document);
	}
}

