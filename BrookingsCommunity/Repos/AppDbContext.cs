using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrookingsCommunity.Models;

namespace BrookingsCommunity.Repos
{
    public class DbContext : DbContext
    {
        public DbContext(
          DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImportantLocation> ImportantLocations { get; set; }
        public DbSet<ImportantPerson> ImportantPeople { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}
