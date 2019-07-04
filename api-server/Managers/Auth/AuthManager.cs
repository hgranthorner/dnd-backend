using System;
using System.Linq;
using api.Managers.Auth;
using api.Models;
using Microsoft.EntityFrameworkCore;
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
            var loggedInUser = Context.Users
                .Include(u => u.UserRoles)
                .ThenInclude(userRoles => userRoles.Role)
                .SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            return loggedInUser;
        }
    }
}
