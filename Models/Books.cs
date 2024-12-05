namespace LibMaster.Models
{
    public class Books
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; } // Each book is associated with one library.

        public int AuthorId { get; set; }
        public Authors Author { get; set; } // Each book is associated with one author.

        public int CategoryId { get; set; }
        public Category Category { get; set; } //Each book is associated with one catogory.
    }
}
