using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Districts;

public record UpdateDistrict() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
}