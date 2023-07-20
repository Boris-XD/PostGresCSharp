using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.Courses
{
    public class Price
    {
        public int Id { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Promocion { get; set; }
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
    }
}