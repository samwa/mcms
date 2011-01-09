
namespace CMSWeb.Models
{
	using System;
	using System.Collections.Generic;

	public interface IDocumentRepository
	{
		Document LoadDocument(int documentId);
		Document LoadDocument(int documentRootId, string status);
		Document LoadDocumentByStructure(int structureId);
		Document LoadDocumentByStructure(int structureId, string status);
		Document LoadDocumentByStructure(int structureId, IList<Status> statuses);
		IList<Document> ListDocuments();
		IList<Document> ListDocuments(string status);
		
		Document AddDocument(Document document);
		Document UpdateDocument(Document document);
		bool DeleteDocument(Document document);
		bool DeleteAll();
	}
}

