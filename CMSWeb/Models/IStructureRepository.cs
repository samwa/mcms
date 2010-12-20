
namespace CMSWeb.Models
{
	using System.Collections.Generic;

	public interface IStructureRepository
	{
		Structure LoadStructure(int StructureId);
		IList<Structure> ListStructures();
		
		Structure AddStructure(Structure structure);
		Structure UpdateStructure(Structure structure);
		bool DeleteStructure(Structure structure);
	}
}

