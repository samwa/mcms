
namespace CMSWeb.Controllers.Admin
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	
	using CMSWeb.Models;

	public class StructureController : BaseController
	{
		IStructureRepository _structureRepository = null;
		
		public StructureController (IStructureRepository structureRepository)
			: base(true)
		{
			_structureRepository = structureRepository;			
		}
		
		//
        // GET: /Structure/		
 
		[Authorize]
		public ActionResult Index()
        {
            return RedirectToAction("List");
        }
		
		[Authorize]
		public ActionResult List()
		{
			IList<Structure> structure = _structureRepository.ListStructures();
			return View(structure);
		}
		
        //
        // GET: /Structure/Details/5
		
		[Authorize]
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Structure/Create
		
		[Authorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Structure/Create
		
		[Authorize]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Structure structure)
        {
            try
            {
                // TODO: Add insert logic here
				_structureRepository.AddStructure(structure);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Structure/Edit/5
 
		[Authorize]
        public ActionResult Edit(int id)
        {
			Structure structure = _structureRepository.LoadStructure(id);
            return View(structure);
        }

        //
        // POST: /Structure/Edit/5
		 
		[Authorize]
		[AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Structure structure)
        {
			
                // TODO: Add update logic here
				structure = new Structure{ StructureID = 1, StructureName = "test", StructureParentID = null};
				if (!TryUpdateModel(structure, new[] { "StructureID", "StructureName" }))
				{
					
				}
				//UpdateModel(structure);
				_structureRepository.UpdateStructure(structure);
                return RedirectToAction("Index");
			
        }
		
		[Authorize]
        public ActionResult Delete(string id)
        {
			_structureRepository.DeleteStructure(Convert.ToInt32(id));


            return RedirectToAction("List");
        }
		
		public ActionResult Menu()
		{
			IList<Structure> structure = _structureRepository.ListStructures();
			return View(structure);
		}
	}
}

