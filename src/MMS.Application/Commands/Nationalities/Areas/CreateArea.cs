using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Areas;

public record CreateArea() : ICommand
{
    public string Name { get; set; }
    public Guid StateId { get; set; }
    public string Prefix { get; set; }
}
