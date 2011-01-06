
namespace CMSWeb.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class DocumentRepository : RepositoryBase, IDocumentRepository
	{
		public DocumentRepository (string connectionString)
			:base(connectionString)
		{
			
		}

		#region IDocumentRepository implementation
		public Document LoadDocument (int documentId)
		{
			Document document = 
				(from d in _db.Document 
				where d.DocumentID == documentId
				select d)
					.FirstOrDefault();
			
			return document;
		}
		
		public Document LoadDocumentByStructure (int structureId)
		{
			Document document = 
				(from d in _db.Document 
				 join s in _db.Structure on d.DocumentID equals s.StructureDocumentID				 
				where s.StructureID == structureId
				select d)
					.FirstOrDefault();
			
			return document;
			
		}

		public IList<Document> ListDocuments ()
		{
			throw new NotImplementedException ();
		}

		public IList<Document> ListDocuments (string status)
		{
			List<Document> documents = 
				(from d in _db.Document
				 where d.DocumentStatus == status
				 select d)
					.ToList();
			
			return documents;
		}

		public Document AddDocument (Document document)
		{
			_db.Document.InsertOnSubmit(document);
			_db.SubmitChanges();
			
			return document;
		}

		public Document UpdateDocument (Document document)
		{
			Document oldDocument = LoadDocument(document.DocumentID.Value);
			
			oldDocument.DocumentName = document.DocumentName;
			oldDocument.DocumentData = document.DocumentData;
			oldDocument.DocumentStatus = document.DocumentStatus;

			_db.SubmitChanges();
			
			return document;
		}

		public bool DeleteDocument (Document document)
		{
			throw new NotImplementedException ();
		}
		#endregion
}
}

