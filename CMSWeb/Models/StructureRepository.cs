using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Mono.Data.Sqlite;

namespace CMSWeb.Models
{
	public class StructureRepository : IStructureRepository
	{	
		protected Main _db;
		public StructureRepository (string connectionString)
		{
			string connection = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
			var conn = new SqliteConnection(connection);
			_db = new Main(conn);
			
		}
		
		#region IStructureRepository implementation
		public Structure LoadStructure (int StructureId)
		{
			throw new NotImplementedException ();
		}
		
		public IList<Structure> ListStructures ()
		{
			List<Structure> structuresList = new List<Structure>();
			
			var structures = 
				from s in _db.Structure
				select s;	        
			
			structuresList = structures.ToList();
			
			return structuresList;
		}

		public Structure AddStructure (Structure structure)
		{
			throw new NotImplementedException ();
		}

		public Structure UpdateStructure (Structure structure)
		{
			throw new NotImplementedException ();
		}

		public bool DeleteStructure (Structure structure)
		{
			throw new NotImplementedException ();
		}
		#endregion
}
}

