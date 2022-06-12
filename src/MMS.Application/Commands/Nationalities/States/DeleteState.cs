using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.States;

public record DeleteState() : ICommand
{
    public Guid Id { get; set;}
}