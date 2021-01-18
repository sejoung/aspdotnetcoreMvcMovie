using Microsoft.EntityFrameworkCore;
using MvcMovie.Constants;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Movie>().Property(c=> c.Rating).HasConversion<string>();
            modelBuilder.Entity<Movie>().Property(c => c.Rating).HasDefaultValue(MovieRating.G);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movie { get; set; }
    }
}