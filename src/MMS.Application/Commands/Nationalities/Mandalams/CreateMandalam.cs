using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record CreateMandalam() : ICommand
{
    public string Name{ get; set; }
    public Guid DistrictId { get; set; }
}