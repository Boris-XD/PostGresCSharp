using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime SynchronizedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }

        [InverseProperty(nameof(Note.Location))]
        public virtual IEnumerable<Note> Notes { get; set; }
    }
}
