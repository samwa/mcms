using System;
using System.Web.Mvc;

using Microsoft.Practices.Unity;

using CMSCore.Services;
using CMSCore.Repositories;

namespace CMSWeb
{
	// configure dependancy injection using Unity
	public class CMSContainer : UnityContainer
	{
		public CMSContainer ()
			: base()
		{
			
		}
		
		public void InstallComponents()
		{	
			// Register repositories
			this.RegisterType<IDocumentRepository, DocumentRepository>();
			this.RegisterType<IUserRepository, UserRepository>();
			
			// Register services
			this.RegisterType<IDocumentService, DocumentService>();
			this.RegisterType<IUserService, UserService>();
			
			// add the container to the controller factory (this makes the repos and services available to the controllers
			CMSControllerFactory controllerFactory = new CMSControllerFactory(this);
			ControllerBuilder.Current.SetControllerFactory(controllerFactory);
		}
	}
}

