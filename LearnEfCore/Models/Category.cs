using System.Collections.Generic;

namespace LearnEfCore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //colleciton navigation property
        public ICollection<Book> Books { get; set; }
    }
}
