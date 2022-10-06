using Microsoft.EntityFrameworkCore;
using Workshop_Forum_App__CRUD_Operations_.Data.Configuration;
using Workshop_Forum_App__CRUD_Operations_.Data.Models;

namespace Workshop_Forum_App__CRUD_Operations_.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Post>(new PostConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
