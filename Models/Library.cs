namespace LibMaster.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //Initializes the collection to ensure the Library class
        // starts with an empty list of books instead of null ref
       public ICollection<Books> Books { get; set; } = new List<Books>();
    }
}
