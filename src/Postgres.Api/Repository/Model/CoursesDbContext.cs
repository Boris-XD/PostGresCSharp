using Microsoft.EntityFrameworkCore;
using Postgres.Api.Repository.Instructors;

namespace Postgres.Api.Repository.Model
{
    public class CoursesDbContext : DbContext
    {
        private const string connectionString = @"Host=localhost;Port=54455;Username=buildinglink;Password=Password1!;Database=shiftlog;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Instructor> Instructor { get; set; } 
    }
}