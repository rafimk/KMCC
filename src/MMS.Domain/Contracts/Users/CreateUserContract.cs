using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Contracts.Users;

public record UserCreateContract()
{
    public GenericId Id { get; set; }
    public FullName FullName { get; set; }
    public Email Email { get; set; }
    public MobileNumber MobileNumber { get; set; } 
    public MobileNumber AlternativeContactNumber { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
}