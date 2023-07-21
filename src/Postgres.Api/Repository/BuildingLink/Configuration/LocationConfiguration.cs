using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Api.Repository.BuildingLink.Models;

namespace Postgres.Api.Repository.BuildingLink.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> entity)
        {
            entity.Property(e => e.SynchronizedAt).HasDefaultValueSql("current_timestamp");
        }
    }
}
