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
		public Structure LoadStructure (int structureId)
		{
			Structure structure = 
				(from s in _db.Structure 
				where s.StructureID == structureId
				select s)
					.FirstOrDefault();
			
			return structure;
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
			_db.Structure.InsertOnSubmit(structure);
			_db.SubmitChanges();
			
			return structure;
		}

		public Structure UpdateStructure (Structure structure)
		{
			_db.Structure.Attach(structure);
			_db.SubmitChanges();
			
			return structure;
		}

		public bool DeleteStructure (int structureId)
		{
			Structure structure = LoadStructure(structureId); 
			_db.Structure.DeleteOnSubmit(structure);
			_db.SubmitChanges();
			
			return true;
		}
		#endregion
}
}

