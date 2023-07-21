using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Api.Repository.BuildingLink.Models;

namespace Postgres.Api.Repository.BuildingLink.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> entity)
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp");
        }
    }
}
