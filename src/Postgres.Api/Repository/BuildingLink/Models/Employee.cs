using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        public int? ImageId { get; set; }

        public DateTime SynchronizedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }
    }
}
