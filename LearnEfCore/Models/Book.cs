//using System.ComponentModel.DataAnnotations;

using System;

namespace LearnEfCore.Models
{
    public class Book
    {
        //[Key] Property Constraints için  bu şekilde data annotation kullanmak tercih edilmemesi gereken bir yaklaşım
        // bunun yerine fluent api kullanacağız
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
