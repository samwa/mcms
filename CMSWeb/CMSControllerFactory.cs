using System;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace CMSWeb
{
	public class CMSControllerFactory : DefaultControllerFactory
	{
		private readonly IUnityContainer _container;
		
		public CMSControllerFactory (IUnityContainer container)
		{
			_container = container;
		}
		
		protected override IController GetControllerInstance (Type controllerType)
		{
			return _container.Resolve(controllerType) as IController;
		}
	}
}

