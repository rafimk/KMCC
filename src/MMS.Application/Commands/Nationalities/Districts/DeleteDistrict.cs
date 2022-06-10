using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record DeleteDistrict() : ICommand
{
    public Guid Id { get; set;}
}