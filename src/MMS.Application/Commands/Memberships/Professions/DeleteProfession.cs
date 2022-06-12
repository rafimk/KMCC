using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Professions;

public record DeleteProfession() : ICommand
{
    public Guid Id { get; set;}
}