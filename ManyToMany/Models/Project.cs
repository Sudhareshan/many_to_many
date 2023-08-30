namespace ManyToMany.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public ICollection<Employe> employes { get; set; }
    }
}
