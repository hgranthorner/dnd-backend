using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;
using static api.Models.MyContext;

namespace api.Managers.Seed
{
    public class SeedRoomManager : SeedManagerBase<Room>, ISeedManager<Room>
    {
        public SeedRoomManager(MyContext context) : base(context)
        {
        }

        protected override async Task<List<Room>> SeedData()
        {
            var room1 = new Room { Name = "test room" };
            var room2 = new Room { Name = "test room" };
            var room3 = new Room { Name = "test room" };
            Context.Rooms.AddRange(room1, room2, room3);
            Context.SaveChanges();
            return await Context.Rooms.ToListAsync();
        }
    }
}
