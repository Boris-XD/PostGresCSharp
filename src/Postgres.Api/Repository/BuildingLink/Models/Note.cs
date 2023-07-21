using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Notes")]
    public class Note
    {
        [Key]
        public Guid Id { get; set; }

        public int? LocationId { get; set; }

        public int? OccupancyId { get; set; }

        [Column("Note")]
        public string? Notes { get; set; }

        public bool IsHighPriority { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedByEmployeeId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int? DeletedByEmployeeId { get; set; }

        public Guid? EmailId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public virtual Location? Location { get; set; }

        [ForeignKey(nameof(OccupancyId))]
        public virtual Occupancy? Occupancy { get; set; }

        [ForeignKey(nameof(EmailId))]
        public virtual Email Email { get; set; }
    }
}
