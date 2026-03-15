using System;

namespace LibraryManagementSystem.Contracts.Entities;

public class BaseUser : BaseEntity
{
    public string FullName { get; set; } = default!;
}
