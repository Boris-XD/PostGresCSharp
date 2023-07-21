using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Api.Repository.BuildingLink.Models
{
    [Table("Properties")]
    public class Property
    {
        [Key]
        public int Id { get; set; }

        public bool IsShiftLogSearchManagerOnly { get; set; }

        public bool IsShiftLogNightlyReport { get; set; }

        public bool IsShiftLogEmailHighPriorityOnly { get; set; }

        public bool IsActive { get; set; }

        public DateTime SynchronizedAt { get; set; }

        [InverseProperty(nameof(ReportEmailAddress.Property))]
        public virtual IEnumerable<ReportEmailAddress> ReportEmailAddresses { get; set; }

        [InverseProperty(nameof(Unit.Property))]
        public virtual IEnumerable<Unit> Units { get; set; }

        [InverseProperty(nameof(Employee.Property))]
        public virtual IEnumerable<Employee> Employees { get; set; }

        [InverseProperty(nameof(Location.Property))]
        public virtual IEnumerable<Location> Locations { get; set; }

        [InverseProperty(nameof(Occupancy.Property))]
        public virtual IEnumerable<Occupancy> Occupancies { get; set; }

        [InverseProperty(nameof(Email.Property))]
        public virtual IEnumerable<Email> Emails { get; set; }
    }
}
