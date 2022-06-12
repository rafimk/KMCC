using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.States;

public record CreateState() : ICommand
{
    public Guid Id { get; set; }
    public string Name{ get; set; }
}