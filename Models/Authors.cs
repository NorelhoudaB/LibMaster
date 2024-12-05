namespace LibMaster.Models
{
    public class Authors
    {
        public int AuthorsId { get; set; }
        public string Name { get; set; }
        public ICollection<Books> Books { get; set; } = new List<Books>();
    }
}
