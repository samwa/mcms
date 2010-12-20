
namespace CMSWeb.Controllers.Admin
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Mvc.Ajax;
	
	using CMSWeb.Models;

	public class StructureController : Controller
	{
		IStructureRepository _structureRepository = null;
		
		public StructureController (IStructureRepository structureRepository)
		{
			_structureRepository = structureRepository;
			
		}
		
		//
        // GET: /Structure/

        public ActionResult Index()
        {
            return View();
        }
		
		public ActionResult List()
		{
			IList<Structure> structure = _structureRepository.ListStructures();
			return View(structure);
		}
		
        //
        // GET: /Structure/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Structure/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Structure/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Structure/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Structure/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
	}
}

