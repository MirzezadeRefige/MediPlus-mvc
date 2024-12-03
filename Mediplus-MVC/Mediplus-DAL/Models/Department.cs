namespace Mediplus_DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Services> Services { get; set; }
    }
}
