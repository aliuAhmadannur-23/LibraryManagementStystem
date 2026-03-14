using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; } = default!;

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = default!;

        [MaxLength(13)]
        public string ISBN { get; set; } = default!;

        [Required]
        public int AuthorId { get; set; }  // Foreign Key

        [ForeignKey("AuthorId")]
        public Author Author { get; set; } = default!;

        [Required]
        public int CategoryId { get; set; }  // Foreign Key

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = default!;

        [MaxLength(100)]
        public string Publisher { get; set; } = default!;

        public int YearPublished { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

     //   public string CoverImageUrl { get; set; } = default!;

        public bool IsActive { get; set; } = true;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime? DateUpdated { get; set; }
    }
}