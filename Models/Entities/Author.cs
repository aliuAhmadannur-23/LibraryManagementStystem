using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = default!;

        public string Biography { get; set; } = default!;

        public string ?Nationality { get; set; }

         
        public ICollection<Book> Books { get; set; }  = default!;
    }
}