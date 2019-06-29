using System.Collections.Generic;
using System.Threading.Tasks;
using api.Managers.Seed;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Seed.Controllers
{
    [Route("api/[controller]")]
    public class SeedController : Controller
    {
        private readonly ISeedManager<User> _userManager;
        private readonly ISeedManager<Room> _roomManager;

        public SeedController(
            ISeedManager<User> userManager,
            ISeedManager<Room> roomManager)
        {
            _userManager = userManager;
            _roomManager = roomManager;

        }

        [HttpPost("users")]
        public async Task<List<User>> SeedUsers()
        {
            var results = await _userManager.Seed();
            return results;
        }

        [HttpPost("rooms")]
        public async Task<List<Room>> SeedRooms()
        {
            var results = await _roomManager.Seed();
            return results;
        }

    }
}
