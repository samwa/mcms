
namespace CMSWeb.Models
{
	using System;
	using System.Configuration;
	
	using Mono.Data.Sqlite;

	public class RepositoryBase : IRepositoryBase
	{
		private string _connection;
		protected Main _db;
		
		public RepositoryBase (string connectionString)
		{
			string connection = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
			var conn = new SqliteConnection(connection);
			_db = new Main(conn);
		}
	}
}

