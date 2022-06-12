using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Users;

public record UpdateUser() : ICommand
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string AlternativeContactNumber { get; set; }
}