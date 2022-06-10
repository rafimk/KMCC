using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Professions;

public record CreateProfession() : ICommand
{
    public string Name{ get; set; }
}