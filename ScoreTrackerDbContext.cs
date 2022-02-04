using Microsoft.EntityFrameworkCore;
using ScoreTracker.Entities;

namespace ScoreTracker
{
    public class ScoreTrackerDbContext : DbContext
    {
        public DbSet<Score> Scores { get; set; }

        public ScoreTrackerDbContext(DbContextOptions<ScoreTrackerDbContext> options) : base(options)
        {

        }
    }
}
