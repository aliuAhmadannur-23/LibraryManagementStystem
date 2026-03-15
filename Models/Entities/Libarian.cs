using System;
using System.Xml.Linq;
using LibraryManagementSystem.Contracts.Entities;
namespace LibraryManagementSystem.Models.Entities.User;

public class Libarian : BaseUser
    {
       public required string LibrarianRegistrationCode { get; set; }
       public required Guid UserId {  get; set; }
       public BaseUser? User { get; set; }
    
}
