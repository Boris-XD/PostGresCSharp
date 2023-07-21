using Microsoft.EntityFrameworkCore;
using Postgres.Api.Repository.Courses;
using Postgres.Api.Repository.Instructors;
/*
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
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }

        public DbSet<Instructor> Instructor { get; set; } 
        public DbSet<Course> Courses { get; set; }

        public DbSet<Price> Price { get; set; }
    }

CoursesDbContext
}*/