using System;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Commands.Qualifications;

public record CreateQualification() : ICommand
{
    public string Name{ get; set; }
}