
namespace CMSWeb.Models
{
	using System;
	
	
	
	public partial class Document : IDocument
	{
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
	}
	
	public enum Status
	{		
		Pending,
		Live,
		Expiried
	}
}

