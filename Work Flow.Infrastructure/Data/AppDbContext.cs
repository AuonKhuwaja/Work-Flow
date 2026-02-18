using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Boards> Boards { get; set; }
        public DbSet<BoardMembers> BoardMembers { get; set; }
        public DbSet<BoardLists> BoardList { get; set; }
        
    }
}
