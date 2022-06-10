using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record CreateDistrict() : ICommand
{
    public string Name{ get; set; }
}