using System;
using System.Collections.Generic;
using CMSCore.Entities;

namespace CMSCore.Repositories
{
	public class DocumentRepository : RepositoryBase, IDocumentRepository
	{
		
		public DocumentRepository (string connectionString)
			:base(connectionString)
		{
		}

		#region IDocumentRepository implementation
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

