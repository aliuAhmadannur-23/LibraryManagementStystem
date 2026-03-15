using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryManagementSystem.Contracts.Entities;

namespace LibraryManagementSystem.Models
{
    public class Book: BaseEntity
    {
        [MaxLength(200)]
        public string Title { get; set; } = default!;
 
        public string ISBN { get; set; } = default!;

        [Required]
        public int AuthorId { get; set; }  // Foreign Key

        [ForeignKey("AuthorId")]
        public Author Author { get; set; } = default!;

        [Required]
        public int CategoryId { get; set; }  // Foreign Key

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = default!;
 
        public int PublishedYear { get; set; } = default!;

        public int YearPublished { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

     //   public string CoverImageUrl { get; set; } = default!;
 

    }
}