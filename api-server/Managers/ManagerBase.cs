using System;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Managers
{
    public class ManagerBase
    {
        protected MyContext Context;
        public ManagerBase(MyContext context)
        {
            Context = context;
        }
    }
}
