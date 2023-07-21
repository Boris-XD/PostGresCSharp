using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Api.Repository.BuildingLink.Models;

namespace Postgres.Api.Repository.BuildingLink.Configuration
{
    public class ReportEmailAddressConfiguration : IEntityTypeConfiguration<ReportEmailAddress>
    {
        public void Configure(EntityTypeBuilder<ReportEmailAddress> entity)
        {
        }
    }
}
