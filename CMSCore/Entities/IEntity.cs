
namespace CMSCore.Entities
{
	using System;
	
	public interface IEntity
	{
		void OnCreated();
		void SendPropertyChanging();
		void SendPropertyChanged(string propertyName);
	}
}

