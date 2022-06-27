using System;

namespace LearnEfCore.Models
{
    public class Author
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        // ignore edilecek 
        public string FullName => 
            string.Concat(FirstName,"  ", LastName);

        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}
