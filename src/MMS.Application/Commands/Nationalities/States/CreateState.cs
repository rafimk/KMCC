using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record CreateState() : ICommand
{
    public string Name{ get; set; }
}