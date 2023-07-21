using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    public class ReportEmailAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int PropertyId { get; set; }

        [MaxLength(320)]
        public string EmailAddress { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }
    }
}
