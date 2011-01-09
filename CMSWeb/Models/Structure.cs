namespace CMSWeb.Models
{
	public partial class Structure : IStructure
	{
		private IStructureRepository _structureRepository;
		
		public Structure (IStructureRepository structureRepository)
			: this()
		{
			_structureRepository = structureRepository;
		}
		
		public bool DeleteAll()
		{
			_structureRepository.DeleteAll();
			return true;
		}
	}
}

