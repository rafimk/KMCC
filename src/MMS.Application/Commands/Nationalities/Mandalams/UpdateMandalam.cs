using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Mandalams;

public record UpdateMandalam() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
    public Guid DistrictId { get; set; }
}