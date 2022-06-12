using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Nationalities.Panchayats;

public record DeletePanchayat() : ICommand
{
    public Guid Id { get; set;}
}