using Microsoft.EntityFrameworkCore;
using VideoRentalOnlineStore.Models.Entities;

namespace VideoRentalOnlineStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>();
            modelBuilder.Entity<Rental>();
        }

       
    }
}
