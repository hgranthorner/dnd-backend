using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static api.Models.MyContext;

namespace api.Managers.Seed
{
    public class SeedUserManager : SeedManagerBase<User>, ISeedManager<User>
    {
        public SeedUserManager(MyContext context) : base(context)
        { }

        protected override async Task<List<User>> SeedData()
        {
            var user = new User { Username = "test2", Password = "test2", Email = "test2@email.com" };
            await Context.Users.AddAsync(user);
            await Context.SaveChangesAsync();
            return await Context.Users.ToListAsync();
        }
    }
}
