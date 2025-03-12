using Microsoft.EntityFrameworkCore;

namespace DefinexAPI.Models
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        //base ilgili classın üretildiği classın constructoruna cagrı yapıyoruz
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}
