using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.Contracts.Entities;

namespace LibraryManagementSystem.Models
{
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public bool IsActive { get; set; } = true;

        public ICollection<Book> Books { get; set; }  = default!;
    }
}