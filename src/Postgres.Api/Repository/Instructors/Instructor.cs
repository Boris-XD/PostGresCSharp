namespace Postgres.Api.Repository.Instructors
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Grade { get; set; }
        public byte[] Photo { get; set; }
    }
}
