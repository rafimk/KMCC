using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships;

public record UpdateMembershipPeriod() : ICommand
{
    public Guid Id { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End {get; set;}
    public DateTimeOffset RegistrationUntil { get; set; }
}