using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Professions;

public record UpdateProfession() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
}