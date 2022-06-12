using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Areas;

public record UpdateArea() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
    public Guid StateId { get; set; }
    public string Prefix { get; set; }
}
