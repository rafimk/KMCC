using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands;

public record DeletePanchayat() : ICommand
{
    public Guid Id { get; set;}
}