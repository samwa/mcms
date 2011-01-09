namespace CMSWeb.Models
{	
	using System.Collections.Generic;
	public interface IUser
	{		
		IList<UserRole> UserRole { get; }
		bool DeleteAll(string roleName);
	}
}

