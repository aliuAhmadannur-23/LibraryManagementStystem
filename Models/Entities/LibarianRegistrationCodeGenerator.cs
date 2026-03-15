using System;
using LibraryManagementSystem.Contracts.Entities;
namespace LibraryManagementSystem.Models.Entities;
 
    public class LibrarianRegistrationCodeGenerator : BaseEntity
    {
        public required string LibrarianRegistrationCode { get; set; }
        public required string Email { get; set; }
        public required DateTime Expiry { get; set; }
        public bool IsUsed { get; set; }
    }
 
