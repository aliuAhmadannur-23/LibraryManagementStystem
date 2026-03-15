using System;
using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem.Contracts.Entities;

namespace LibraryManagementSystem.Models.User
{
    public class Member : BaseEntity
        {
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required string MembershipNumber { get; set; }
        public required Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
