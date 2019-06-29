using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Managers.Seed
{
    public abstract class SeedManagerBase<T> : ManagerBase
    {
        public SeedManagerBase(MyContext context) : base(context)
        { }

        public async Task<List<T>> Seed()
        {
            return await SeedData();
        }

        protected abstract Task<List<T>> SeedData();
    }
}
