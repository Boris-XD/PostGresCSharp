using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Units")]
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        [MaxLength(24)]
        public string? Label { get; set; }

        [MaxLength(40)]
        public string Number { get; set; }

        public bool IsActive { get; set; }

        public DateTime SynchronizedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }

        [InverseProperty(nameof(Occupancy.Unit))]
        public IEnumerable<Occupancy> Occupancies { get; set; }
    }
}
