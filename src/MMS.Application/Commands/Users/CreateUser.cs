using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record CreateUser() : ICommand
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string AlternativeContactNumber { get; set; }
    public UserRole Role { get; set; }
}
