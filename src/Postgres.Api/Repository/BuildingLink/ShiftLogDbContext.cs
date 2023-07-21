using Microsoft.EntityFrameworkCore;
using Postgres.Api.Repository.BuildingLink.Configuration;
using Postgres.Api.Repository.BuildingLink.Models;
using System.Diagnostics.CodeAnalysis;

namespace Postgres.Api.Repository.BuildingLink;

/// <summary>
/// Bd context is the object to represents the database integration.
/// </summary>
[ExcludeFromCodeCoverage]
public class ShiftLogDbContext : DbContext
{
    private const string connectionString = @"Host=localhost;Port=54455;Username=buildinglink;Password=Password1!;Database=shiftlog;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
    }

    public DbSet<Property> Properties { get; set; }

    public DbSet<Email> Emails { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Location> Locations { get; set; }

    public DbSet<Note> Notes { get; set; }

    public DbSet<Occupancy> Occupancies { get; set; }

    public DbSet<ReportEmailAddress> ReportEmailAddresses { get; set; }

    public DbSet<Unit> Units { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PropertyConfiguration());
        modelBuilder.ApplyConfiguration(new EmailConfiguration());
        modelBuilder.ApplyConfiguration(new OccupancyConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new NoteConfiguration());
        modelBuilder.ApplyConfiguration(new ReportEmailAddressConfiguration());
        modelBuilder.ApplyConfiguration(new UnitConfiguration());
    }
}