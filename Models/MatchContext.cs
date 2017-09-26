using Microsoft.EntityFrameworkCore;

namespace match.Models
{
    public class MatchContext : DbContext {
         public MatchContext(DbContextOptions<MatchContext> options) : base(options) 
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}