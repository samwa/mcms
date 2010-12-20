
namespace CMSWeb.Models
{
	using System;
	using System.Configuration;

	public class RepositoryBase : IRepositoryBase
	{
		private string _connection;
		protected Main _db;
		
		public RepositoryBase (string connectionString)
		{
			_connection = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
			_db = new Main(connectionString);
		}
	}
}

