using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrookingsCommunity.Models;
using Microsoft.EntityFrameworkCore;

namespace BrookingsCommunity.Repos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
           DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImportantLocation> ImportantLocations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<ImportantPerson> ImportantPeople { get; set; }
    }
}
