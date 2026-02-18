using Microsoft.EntityFrameworkCore;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Boards> Boards { get; set; }
        public DbSet<BoardMembers> BoardMembers { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<BoardLists> BoardLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BoardMembers is a join entity in DB: define a composite PK (BoardId, UserId)
            modelBuilder.Entity<BoardMembers>()
                .HasKey(bm => new { bm.BoardId, bm.UserId });

            // Let EF conventions map BoardLists -> BoardLists table and Order -> Order column.
            // If you prefer explicit relational mapping, add Microsoft.EntityFrameworkCore.SqlServer package.
            base.OnModelCreating(modelBuilder);
        }
    }
}
