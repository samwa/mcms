namespace CMSWeb.Models
{	
	public interface IDocument
	{
		Document Load(int? structureId);
		Document Load(int? structureId, Status status);
		Document Add(Document document);
		Document Update(Document document);
		void Publish();
		void Reject();
		void Rollback(Document document);
		bool DeleteAll();			
	}
}

