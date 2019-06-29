using System;
using api.Models;
using static api.Models.MyContext;

namespace api.Managers.Auth
{
    public interface IAuthManager
    {
        User Login(User user);
    }
}
