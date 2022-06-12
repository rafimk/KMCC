using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships;

public record ActivateMembershipPeriod() : ICommand
{
    public Guid Id { get; set; }
}