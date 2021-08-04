using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class EFContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTagMap> PostsTagsMaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTagMap>()
                .HasKey(sc => new { sc.PostId, sc.TagId });

            modelBuilder.Entity <PostTagMap> ()
                            .HasOne<Post>(sc => sc.post)
                            .WithMany(s => s.Connect)
                            .HasForeignKey(sc => sc.PostId);


            modelBuilder.Entity <PostTagMap> ()
                        .HasOne<Tag>(sc => sc.tag)
                        .WithMany(s => s.Connect)
                        .HasForeignKey(sc => sc.TagId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;" +
               "Port=5432;" +
               "Database=dbblog;" +
               "Username=postgres;" +
               "Password=1234567");
        }
    }
}

