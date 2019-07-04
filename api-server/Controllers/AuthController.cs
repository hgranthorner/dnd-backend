using System.Collections.Generic;
using api.Managers.Auth;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static api.Models.MyContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IAuthManager _manager;

        public AuthController(IAuthManager manager) => _manager = manager;

        [HttpPost("login")]
        public User Post([FromBody]User userInfo)
        {
            var user = _manager.Login(userInfo);
            return user;
        }
    }
}
