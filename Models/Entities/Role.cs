using System;
using LibraryManagementSystem.Contracts.Entities;

namespace LibraryManagementSystem.Models.User;

 
    public class Role : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
