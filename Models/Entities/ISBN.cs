using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class ISBN
    {
        [Key]
        public int ISBNId { get; set; }

        [Required]
        [MaxLength(13)]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$",
            ErrorMessage = "Invalid ISBN. Must be ISBN-10 or ISBN-13.")]
        public string Code { get; set; } = default!;

        [Required]
        public int BookId { get; set; }  // Foreign Key
        [ForeignKey("BookId")]
        public Book Book { get; set; }  = default!;

        public string Edition { get; set; }    = default!;
        public string Format { get; set; }     = default!; 
        public DateTime PublishedDate { get; set; }
        public bool IsActive { get; set; } = true; 
    }
}