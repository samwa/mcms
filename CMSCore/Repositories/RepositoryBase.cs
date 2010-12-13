
namespace CMSCore.Repositories
{
	using System;
	using System.Configuration;

	public class RepositoryBase
	{
		string _connection;
		
		public RepositoryBase (string connectionString)
		{
			_connection = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
		}
	}
}

