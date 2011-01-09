
namespace CMSWeb.Models
{
	using System.Collections.Generic;

	public interface IStructureRepository
	{
		Structure LoadStructure(int structureId);
		IList<Structure> ListStructures();
		
		Structure AddStructure(Structure structure);
		Structure UpdateStructure(Structure structure);
		bool DeleteStructure(int structureId);
		bool DeleteAll();
	}
}

