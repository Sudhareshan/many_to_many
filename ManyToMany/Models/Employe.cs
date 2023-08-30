namespace ManyToMany.Models
{
    public class Employe
    {
        public int EmployeId { get; set; }
        public string Name { get; set; }

        public ICollection<Project> projects { get; set; }
    }
}
