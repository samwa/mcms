namespace CMSWeb.Models
{
	using System;
	
	public enum Status
	{		
		Draft, // content being added by user
		Review, // content waiting to be reviewed by admin
		Live, // current content
		Expiried // old content
	}	
	
	public partial class Document : IDocument
	{
		private static IDocumentRepository _documentRepository;
		
		public Document(IDocumentRepository documentRepository)
			: this()
		{
			_documentRepository = documentRepository;
		}
		
		// for cloning
		public Document (Document another)
		{
			this.DocumentName = another.DocumentName;
			this.DocumentRootID = another.DocumentRootID;
			this.DocumentData = another.DocumentData;
			this.DocumentStatus = another.DocumentStatus;
		}
		
		public Status Status {
			get 
			{
				return DocumentStatus.EnumParse<Status>();
			}
			set
			{
				DocumentStatus = Enum.GetName(typeof(Status), value);
			}
		}
		
		public DateTime? Created {
			get { return DateTime.Parse(DocumentCreated); }
			set { DocumentCreated = value.ToString(); }
		}
		
		public DateTime? Modified {
			get { return DateTime.Parse(DocumentModified); }
			set { DocumentModified = (value ?? new DateTime()).ToString(); }
		}
		
		public Document Load(int? structureId)
		{
			// get the review doc
			return Load(structureId, Status.Review);
		}
		
		public Document Load(int? structureId, Status status)
		{
			if (!structureId.HasValue)
				return null;
			
			string documentStatus = Enum.GetName(typeof(Status), status);
			string liveStatus = Enum.GetName(typeof(Status), Status.Live);
			
			// get document based on status
			Document document = _documentRepository.LoadDocumentByStructure(structureId.Value, documentStatus);
			
			// get live document
			if (document == null)
				document = _documentRepository.LoadDocumentByStructure(structureId.Value, liveStatus);
			
			return document;
		}
		
		public Document Add(Document document)
		{
			// 
			return _documentRepository.AddDocument(document);
		}
		
		public Document Update(Document document)
		{
			// create a new review document if current is live
			if (this.Status == Status.Live)
			{
				document.DocumentID = null;
				return _documentRepository.AddDocument(document);
			}
			else if (this.Status == Status.Review)
			{				
				// update review document if current is review
				document.DocumentID = this.DocumentID;
				return _documentRepository.UpdateDocument(document);
			}
			
			return null;
		}
		
		public void Publish()
		{
			// expire old document
			if (this.DocumentRootID.HasValue)
			{
				Document oldDocument = _documentRepository.LoadDocument(this.DocumentRootID.Value, StatusToString(Status.Live));
				if (oldDocument != null)
				{
					oldDocument.Status = Status.Expiried;
					_documentRepository.UpdateDocument(oldDocument);
				}
			}
			
			// set existing to live
			this.Status = Status.Live;		
			_documentRepository.UpdateDocument(this);
		}
		
		public void Reject()
		{
			throw new NotImplementedException();
		}
		
		public void Rollback (Document document)
		{
			throw new NotImplementedException ();
		}
		
		public string StatusToString(Status status)
	    {
	        return Enum.GetName(typeof(Status), status);
	    }
		
		public bool DeleteAll()
		{
			_documentRepository.DeleteAll();
			return true;
		}
	}
}

