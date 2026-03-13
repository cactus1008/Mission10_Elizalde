using Microsoft.EntityFrameworkCore;

namespace Mission10_Elizalde.Data
{
    public class BowlingDbContext : DbContext
    {
        public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
        {
        }
        public DbSet<BowlingInfo> Bowlers { get; set; }

        public DbSet<Team> Teams { get; set; }
    }
}
