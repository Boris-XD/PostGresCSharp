using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Api.Repository.BuildingLink.Models;

namespace Postgres.Api.Repository.BuildingLink.Configuration
{
    public class OccupancyConfiguration : IEntityTypeConfiguration<Occupancy>
    {
        public void Configure(EntityTypeBuilder<Occupancy> entity)
        {
            entity.Property(e => e.SynchronizedAt).HasDefaultValueSql("current_timestamp");
        }
    }
}
