namespace LibMaster.Models
{

        public class Category
        {

            public int CategoryId { get; set; }
            public string Name { get; set; }
            public ICollection<Books> Books { get; set; } = new List<Books>();
        }
    
}