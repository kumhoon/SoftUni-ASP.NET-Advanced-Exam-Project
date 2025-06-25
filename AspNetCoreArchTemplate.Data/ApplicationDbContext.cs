namespace AspNetCoreArchTemplate.Data
{
    using AspNetCoreArchTemplate.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<ForumSection> ForumSections { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ModeratorAssignment> ModeratorAssignments { get; set; }

        public virtual DbSet<Thread> Threads { get; set; }

        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
