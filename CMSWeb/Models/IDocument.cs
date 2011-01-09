namespace CMSWeb.Models
{	
	public interface IDocument
	{
		//Document Load(int structureId);
		Document Add(Document document);
		Document Update(Document document);
		void Publish();
		void Reject();
		void Rollback(Document document);
	}
}

