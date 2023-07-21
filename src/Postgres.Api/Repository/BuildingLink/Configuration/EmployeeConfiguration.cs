using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Api.Repository.BuildingLink.Models;

namespace Postgres.Api.Repository.BuildingLink.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.Property(e => e.SynchronizedAt).HasDefaultValueSql("current_timestamp");
        }
    }
}
