using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships;

public record DeactivateMembershipPeriod() : ICommand
{
    public Guid Id { get; set; }
}