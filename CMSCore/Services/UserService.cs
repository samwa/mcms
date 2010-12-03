using System;

using CMSCore.Repositories;

namespace CMSCore.Services
{
	public class UserService : IUserService
	{
		IUserRepository _userRepository = null;
		
		public UserService (IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
	}
}

