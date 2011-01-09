using System;
namespace CMSWeb.Models
{
	using System.Web.Security;
	using System.Collections.Generic;
	
	public enum UserRole
	{		
		User, // normal user
		Admin // admin user
	}	
	
	public partial class User : MembershipUser, IUser
	{
		private IUserRepository _userRepository;
				
		public User (IUserRepository userRepository)
			: base()
		{
			_userRepository = userRepository;
		}
		
		public User(User another)
		{
			this.UserLogin = another.UserLogin;
			this.UserEmail = another.UserEmail;
		}
		
		public User Load(string userName)
		{
			MembershipUser mUser = Membership.GetUser(userName);
			this.UserLogin = mUser.UserName;
			this.UserEmail = mUser.Email;
			return this;
		}
		
		public IList<UserRole> UserRole
		{ 
			get
			{
				return Array.ConvertAll(Roles.GetRolesForUser(this.UserLogin),
					new Converter<string, UserRole>(delegate(string role) 
				    	{
							return EnumHelper.EnumParse<UserRole>(role);
						})
				);
			}	
		}
		
		public IList<User> List()
		{
			MembershipUserCollection users = Membership.GetAllUsers();
			List<User> userList = new List<User>();
			
			foreach (MembershipUser user in users) 
			{
				userList.Add(new User { UserEmail = user.Email, UserLogin = user.UserName });
			}
			
			return userList;
		}
		
		public IList<User> List(UserRole role)
		{			
			string[] users = Roles.GetUsersInRole(EnumHelper.EnumToString<UserRole>(role));
			                                                 
			List<User> userList = new List<User>();
			
			foreach (string username in users)
			{
				MembershipUser mUser = Membership.GetUser(username);
				userList.Add(new User { UserEmail = mUser.Email, UserLogin = mUser.UserName });
			}
			
			return userList;
		}
		
		public void AddUserToRole(UserRole role)
		{
			string newRole = UserRoleToString(role);
			Roles.AddUserToRole(this.UserLogin, newRole);
		}
		
		public void RemoveUserFromRole(UserRole role)
		{
			Roles.RemoveUserFromRole(this.UserLogin, UserRoleToString(role));
		}
		
		// delete all users in a role
		public bool DeleteAll(string roleName)
		{
			string[] users = Roles.GetUsersInRole(roleName);
			
			foreach (string user in users) 
			{
				// remove user from roles
				System.Web.Security.Roles.RemoveUserFromRole(user, roleName);
				System.Web.Security.Membership.DeleteUser(user, false);
			}	
				
			return true;
		}
		
		public string UserRoleToString(Models.UserRole role)
	    {
	        return Enum.GetName(typeof(Models.UserRole), role);
	    }
	}
}

