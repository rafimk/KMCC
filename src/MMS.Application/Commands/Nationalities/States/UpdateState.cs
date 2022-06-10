using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record UpdateState() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
}