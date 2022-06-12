using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Mandalams;

public record DeleteMandalam() : ICommand
{
    public Guid Id { get; set;}
}