
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
		
		public Document LoadDocument (int documentRootId, string status)
		{
			Document document = 
				(from d in _db.Document 
				where d.DocumentRootID == documentRootId 
				 && d.DocumentStatus == status
				select d)
					.FirstOrDefault();
			
			return document;
		}
		
		public Document LoadDocumentByStructure (int structureId)
		{
			Document document = 
				(from d in _db.Document 
				 join s in _db.Structure on d.DocumentRootID equals s.StructureDocumentID				 
				where s.StructureID == structureId
				select d)
					.FirstOrDefault();
			
			return document;			
		}
		
		public Document LoadDocumentByStructure (int structureId, string status)
		{
			//string documentStatus = Enum.GetName(typeof(Status), status);
			
			Document document = 
				(from d in _db.Document 
				 join s in _db.Structure on d.DocumentRootID equals s.StructureDocumentID	 
				where s.StructureID == structureId
				 && d.DocumentStatus == status
				 //&& d.Status == status
				select d)
					.FirstOrDefault();
			
			return document;			
		}
		
		public Document LoadDocumentByStructure (int structureId, IList<Status> statuses)
		{
			// this won't work because there is an error in dblinq implementastion of GetLiteral 
			// bloody OS software!
			throw new NotImplementedException ();
			
			//List<Status> statusList = new List<Status>(statuses);
			List<string> documentStatuses = new List<string>(new string [] { "Review", "Live" });
			
			//Document document = 
			//	(from d in _db.Document 
			//	 join s in _db.Structure on d.DocumentID equals s.StructureDocumentID				 
			//	where s.StructureID == structureId
			//	 && statuses.Contains(d.DocumentStatus)
			//	select d)
			//		.FirstOrDefault();
			
			//return document;			
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
			document.Created = DateTime.Now;
			_db.Document.InsertOnSubmit(document);
			_db.SubmitChanges();
			
			// update root id to be the same as doc id
			if (document.DocumentRootID == null)
			{
				document.DocumentRootID = document.DocumentID;
				this.UpdateDocument(document);
			}
			
			return document;
		}

		public Document UpdateDocument (Document document)
		{
			Document oldDocument = LoadDocument(document.DocumentID.Value);
			
			// document object should just set its own properties, but due to 'linq to sql' weirdness we have to set them all here!
			oldDocument.DocumentRootID = document.DocumentRootID;
			oldDocument.DocumentName = document.DocumentName;
			oldDocument.DocumentData = document.DocumentData;
			oldDocument.DocumentStatus = document.DocumentStatus;
			oldDocument.Modified = DateTime.Now;

			_db.SubmitChanges();
			
			return document;
		}

		public bool DeleteDocument (Document document)
		{
			throw new NotImplementedException ();
		}
		
		public bool DeleteAll()
		{
			string sql = "DELETE FROM Document";
			_db.ExecuteCommand(sql);
			
			return true;
		}
		#endregion
	}
}

