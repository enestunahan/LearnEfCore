//using System.ComponentModel.DataAnnotations;

namespace LearnEfCore.Models
{
    public class Book
    {
        //[Key] Property Constraints için  bu şekilde data annotation kullanmak tercih edilmemesi gereken bir yaklaşım
        // bunun yerine fluent api kullanacağız
        public int Id { get; set; } 
        public string Title { get; set; }   
    }
}
