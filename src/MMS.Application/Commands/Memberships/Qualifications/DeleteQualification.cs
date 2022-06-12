using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Qualifications;

public record DeleteQualification() : ICommand
{
    public Guid Id { get; set;}
}