using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Professions;

public record UpdateProfession() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
}