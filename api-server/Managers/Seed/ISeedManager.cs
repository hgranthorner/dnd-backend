using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Managers.Seed
{
    public interface ISeedManager<T>
    {
        Task<List<T>> Seed();
    }
}
