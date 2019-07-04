using System.Collections.Generic;
using System.Linq;
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
            return _context.Users
                .Include(user => user.UserRoles)
                .ThenInclude(userRoles => userRoles.Role)
                .ToListAsync();
        }

        [HttpGet("rooms")]
        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                .ToListAsync();
        }

        [HttpGet("characters/{userId}")]
        public async Task<List<Character>> GetCharacters(int userId)
        {
            return await _context.Characters
                .Where(character => character.PlayerId == userId)
                .ToListAsync();
        }
    }
}
