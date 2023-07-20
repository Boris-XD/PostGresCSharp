using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.Courses
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public DateTime? DatePublish { get; set; }

        [InverseProperty(nameof(Price.Course))]
        public virtual Price Prices { get; set; }
    }
}