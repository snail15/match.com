using Microsoft.EntityFrameworkCore;

namespace match.Models
{
    public class MatchContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Userdetail> Userdetails { get; set; }
        public DbSet<Userprofile> Userprofiles { get; set; }
        public DbSet<Userpreference> Userpreferences { get; set; }
        public DbSet<Userpayment> Userpayments { get; set; }
        public DbSet<Userbioactivity> Userbioactivities { get; set; }
        public MatchContext(DbContextOptions<MatchContext> options) : base(options) { }
    }
}