using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models.User
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }= default!;
        public string  LastName { get; set; }= default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string PhoneNumber { get; set; }= default!;
        public string Role { get; set; } = default!; // Admin, Librarian, Member
        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}