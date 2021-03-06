using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Memberships.Qualifications;

public record UpdateQualification() : ICommand
{
    public Guid Id { get; set;}
    public string Name{ get; set; }
}