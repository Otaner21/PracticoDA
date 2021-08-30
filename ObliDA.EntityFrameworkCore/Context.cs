using Microsoft.EntityFrameworkCore;
using ObliDA.Domain;

namespace ObliDA.EntityFrameworkCore
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public virtual DbSet<User> Users { get; set; }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(c => c.Forecasts).WithOne(e => e.User);
  
        }
    }
}