using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Occupancies")]
    public class Occupancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        public int? UnitId { get; set; }

        [MaxLength(24)]
        public string? Label { get; set; }

        [MaxLength(40)]
        public string Number { get; set; }

        public bool IsActive { get; set; }

        public DateTime SynchronizedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }

        [ForeignKey(nameof(UnitId))]
        public virtual Unit? Unit { get; set; }

        [InverseProperty(nameof(Note.Occupancy))]
        public virtual IEnumerable<Note> Notes { get; set; }
    }
}
