namespace LearnEfCore.Models
{
    public class BookDetail
    {
        public int Id { get; set; }      
        public string ISSN { get; set; }
        public string City { get; set; }
        public  string Country { get; set; }
        public int Year { get; set; }

        // foreign key
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
