using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Districts;

public record DeleteDistrict() : ICommand
{
    public Guid Id { get; set;}
}