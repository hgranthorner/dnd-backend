using System;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
