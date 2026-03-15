using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.Contracts.Entities;
using LibraryManagementSystem.Enums;

namespace LibraryManagementSystem.Models
{
    public class Author : BaseEntity
    {
        [Key]
        public int AuthorId { get; set; }

        public required string Name { get; set; }  
        public Gender Gender { get; set; }

        public string? Nationality { get; set; }

        public ICollection<Book> Books { get; set; } = default!;
    }
}