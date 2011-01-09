

namespace CMSWeb.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
		
	public class StructureRepository : RepositoryBase, IStructureRepository
	{	
		public StructureRepository (string connectionString)
			:base(connectionString)
		{
			
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
			Structure oldStructure = LoadStructure(structure.StructureID.Value);
			
			oldStructure.StructureName = structure.StructureName;			

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
		
		public bool DeleteAll()
		{
			string sql = "DELETE FROM Structure";
			_db.ExecuteCommand(sql);
			
			return true;
		}
		#endregion
}
}

