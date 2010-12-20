using System;
using System.Web.Mvc;

using Microsoft.Practices.Unity;

using CMSWeb.Models;

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
			this.RegisterType<IRepositoryBase, RepositoryBase>();
			this.RegisterType<IDocumentRepository, DocumentRepository>();
			this.RegisterType<IUserRepository, UserRepository>();
			this.RegisterType<IStructureRepository, StructureRepository>();
			
			this.Configure<InjectedMembers>()
				.ConfigureInjectionFor<RepositoryBase>(new InjectionConstructor("DocStoreConn"));
			this.Configure<InjectedMembers>()
				.ConfigureInjectionFor<StructureRepository>(new InjectionConstructor("DocStoreConn"));
			
			// add the container to the controller factory (this makes the repos and services available to the controllers
			CMSControllerFactory controllerFactory = new CMSControllerFactory(this);
			ControllerBuilder.Current.SetControllerFactory(controllerFactory);
		}
	}
}

