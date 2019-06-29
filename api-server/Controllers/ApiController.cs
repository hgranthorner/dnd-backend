using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly MyContext _context;

        public ApiController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("users")]
        public Task<List<User>> GetUsers()
        {
            return _context.Users.ToListAsync();
        }
    }
}
