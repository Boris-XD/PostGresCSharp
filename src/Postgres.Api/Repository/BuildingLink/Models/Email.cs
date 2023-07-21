using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Emails")]
    public class Email
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int PropertyId { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }

        [InverseProperty(nameof(Note.Email))]
        public virtual IEnumerable<Note> Notes { get; set; }
    }
}
