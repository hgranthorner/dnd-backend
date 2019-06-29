using System;
using System.Linq;
using api.Managers.Auth;
using api.Models;
using static api.Models.MyContext;

namespace api.Managers
{
    public class AuthManager : ManagerBase, IAuthManager
    {
        public AuthManager(MyContext context)
            : base(context)
        { }

        public User Login(User user)
        {
            var users = Context.Users.Where(u => u.Username == user.Username && u.Password == user.Password);

            return users?.First();
        }
    }
}
